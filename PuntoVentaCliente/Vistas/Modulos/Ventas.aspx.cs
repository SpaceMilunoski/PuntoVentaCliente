using Newtonsoft.Json;
using PuntoVentaCliente.WSVentas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using iTextSharp.text;
using iTextSharp.text.pdf;

namespace PuntoVentaCliente.Vistas.Modulos
{
    public partial class Ventas : System.Web.UI.Page
    {
        WSVentasSoapClient wsVentas;

        Modelos.Ventas ventas;
        Modelos.ProductosVentas productosVentas;

        DataTable aux;

        protected void Page_Load(object sender, EventArgs e)
        {
            wsVentas = new WSVentasSoapClient();

            ventas = new Modelos.Ventas();
            productosVentas = new Modelos.ProductosVentas();

            aux = new DataTable();
            txtbBusqueda.Focus();

            if (!IsPostBack)
            {
                Session["TablaVentas"] = aux;
                Session["NuevaVenta"] = true;
            }
        }

        protected void GridView_Ventas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try {
                //Se obtiene el indice de la fila la cual se escogio
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView_Ventas.Rows[index];
                
                //Se verifica que boton se escogio si editar o eliminar
                if (e.CommandName == "Quitar") {

                    aux = (DataTable)Session["TablaVentas"];

                    if (Convert.ToInt32(row.Cells[7].Text) > 1)
                    {
                        DataRow rowAux = aux.Rows[index];

                        rowAux["Cantidad"] = Convert.ToInt32(aux.Rows[index].ItemArray[7]) - 1;
                        rowAux["PrecioTotal"] = Convert.ToDouble(aux.Rows[index].ItemArray[5]) * Convert.ToInt32(aux.Rows[index].ItemArray[7]);
                    }
                    else
                        aux.Rows.RemoveAt(index);

                    //Se guarda el datatable
                    Session["TablaVentas"] = aux;

                    //Llena el datagridview
                    GridView_Ventas.DataSource = aux;
                    GridView_Ventas.DataBind();

                    lblTotal.Text = "Total a pagar: " + obtenerTotal().ToString();
                }

            } catch (Exception ex) {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Error del servidor.\", \"error\");", true);
            }

            txtbBusqueda.Focus();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtbBusqueda.Text != "")
            {
                try
                {
                    GridView_Ventas.Columns[0].Visible = true;
                    GridView_Ventas.Columns[6].Visible = true;

                    if (Convert.ToBoolean(Session["NuevaVenta"])) {
                        aux = (DataTable)Session["TablaVentas"];
                        aux.Clear();
                        Session["TablaVentas"] = aux;
                        GridView_Ventas.DataSource = aux;
                        GridView_Ventas.DataBind();
                        lblTotal.Text = "";
                        btnTicket.Visible = false;

                        GridView_Ventas.Visible = true;
                        lblTotal.Visible = true;
                        btnVenta.Visible = true;
                    }

                    aux = (DataTable)Session["TablaVentas"];

                    string json = wsVentas.BuscarProductoParaVenta(txtbBusqueda.Text);
                    DataTable dt = (DataTable)JsonConvert.DeserializeObject(json, typeof(DataTable));
                    

                    if (dt.Rows.Count > 0)
                    {

                        //Agregar las columnas faltantes
                        DataRow row = dt.Rows[0];

                        dt.Columns.Add("Cantidad");
                        dt.Columns.Add("PrecioTotal");

                        row["Cantidad"] = 1;
                        row["PrecioTotal"] = dt.Rows[0].ItemArray[5];

                        //Agregamos la informacion al datatable auxiliar
                        if (aux.Rows.Count == 0)
                            aux = dt.Clone();
                        else
                        {
                            for (int i = 0; i < aux.Rows.Count; i++)
                            {
                                //Verificamos si todavia hay stock
                                if (dt.Rows[0].ItemArray[0].ToString() == aux.Rows[i].ItemArray[0].ToString() &&
                                    Convert.ToInt32(dt.Rows[0].ItemArray[7]) + Convert.ToInt32(aux.Rows[i].ItemArray[7]) > Convert.ToInt32(dt.Rows[0].ItemArray[6]))
                                {
                                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Ya no hay en stock\", \"error\");", true);
                                    txtbBusqueda.Text = string.Empty;
                                    txtbBusqueda.Focus();
                                    return;
                                }
                            }
                        }

                        //Verifica si esta el registro ya en la tabla
                        Boolean nuevoregistro = true;
                        for (int i = 0; i < aux.Rows.Count; i++)
                            if (dt.Rows[0].ItemArray[0].ToString() == aux.Rows[i].ItemArray[0].ToString())
                                nuevoregistro = false;

                        //Si no esta el registro se procede a modificar la tabla auxiliar
                        if (!nuevoregistro)
                        {
                            for (int i = 0; i < aux.Rows.Count; i++)
                            {
                                if (dt.Rows[0].ItemArray[0].ToString() == aux.Rows[i].ItemArray[0].ToString())
                                {
                                    row = aux.Rows[i];

                                    row["Cantidad"] = Convert.ToInt32(aux.Rows[i].ItemArray[7]) + 1;
                                    row["PrecioTotal"] = Convert.ToDouble(aux.Rows[i].ItemArray[5]) * Convert.ToInt32(aux.Rows[i].ItemArray[7]);
                                }
                            }
                        }
                        else
                            aux.Rows.Add(row.ItemArray);


                        //Se guarda el datatable
                        Session["TablaVentas"] = aux;

                        //Llena el datagridview
                        GridView_Ventas.DataSource = aux;
                        GridView_Ventas.DataBind();

                        lblTotal.Text = "Total a pagar: " + obtenerTotal().ToString();
                        GridView_Ventas.Columns[0].Visible = false;
                        GridView_Ventas.Columns[6].Visible = false;

                        Session["NuevaVenta"] = false;

                    } else
                        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"No se encontro el producto o la cantidad de stock no esta actualizada.\", \"error\");", true);
                    
                    txtbBusqueda.Text = string.Empty;

                } catch (Exception ex) {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Error del servidor.\", \"error\");", true);
                }
                
            } else
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Warning\", \"Seleccione e introduzca el codigo del produto.\", \"warning\");", true);

            txtbBusqueda.Focus();
        }

        private Double obtenerTotal()
        {
            Double total = 0;
            aux = (DataTable)Session["TablaVentas"];

            for (int i = 0; i < aux.Rows.Count; i++)
            {
                total += Convert.ToInt32(aux.Rows[i].ItemArray[8]);
            }

            return total;
        }

        protected void btnVenta_Click(object sender, EventArgs e)
        {

            if (GridView_Ventas.Rows.Count > 0) {
                
                
                //Modelo de venta general
                ventas.SubTotal = obtenerTotal();
                ventas.Total = ventas.SubTotal;
                ventas.FechaVenta = System.DateTime.Now.ToString("yyyy-MM-dd");
                ventas.Empleados = Convert.ToString(Session["User"]);

                String json = JsonConvert.SerializeObject(ventas);


                wsVentas.InsertarVentaGeneral(json);

                //Modelo para detalles de ventas
                aux = (DataTable)Session["TablaVentas"];

                for (int i = 0; i < aux.Rows.Count; i++)
                {
                    productosVentas.Productos_Id = Convert.ToInt32(aux.Rows[i].ItemArray[0]);
                    productosVentas.PrecioUnitario = Convert.ToDouble(aux.Rows[i].ItemArray[5]);
                    productosVentas.Cantidad = Convert.ToInt32(aux.Rows[i].ItemArray[7]);
                    productosVentas.PrecioTotal = Convert.ToDouble(aux.Rows[i].ItemArray[8]);

                    json = JsonConvert.SerializeObject(productosVentas);

                    wsVentas.InsertarVentaDetalles(json);
                }

                txtbBusqueda.Focus();
                
                GridView_Ventas.Visible = false;
                lblTotal.Visible = false;
                btnVenta.Visible = false;

                btnTicket.Visible = true;

                Session["NuevaVenta"] = true;
            } else
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Warning\", \"Necesita agregar productos.\", \"warning\");", true);
           
            txtbBusqueda.Focus();
        }

        protected void btnTicket_Click(object sender, EventArgs e)
        {
            txtbBusqueda.Focus();
            btnTicket.Visible = false;
            generarTicket();
        }
        
        private void generarTicket()
        {
            try
            {
                
                Response.ContentType = "application/pdf";
                Response.AddHeader("content-disposition", "attachment;filename=Ticket " + System.DateTime.Now.ToString("dd_MM_yyyy HH_mm_ss") + ".pdf");

                //Document pdfDoc = new Document(PageSize.A8,1,1,1,1);
                Document pdfDoc = new Document(PageSize.A4, 6, 6, 6, 6);

                PdfWriter.GetInstance(pdfDoc, Response.OutputStream);

                pdfDoc.Open();

                //iTextSharp.text.Font text = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 4);
                iTextSharp.text.Font text = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 11);

                pdfDoc.Add(new Paragraph("Ticket"));
                pdfDoc.Add(Chunk.NEWLINE);
                pdfDoc.Add(new Paragraph("Fecha y hora de emision: " + System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), text));
                pdfDoc.Add(Chunk.NEWLINE);
                pdfDoc.Add(new Paragraph("Usuario que le atendio: " + Convert.ToString(Session["User"]), text));
                pdfDoc.Add(Chunk.NEWLINE);

                //Ventas generales
                pdfDoc.Add(Chunk.NEWLINE);
                pdfDoc.Add(new Paragraph("Ventas generales ", text));
                pdfDoc.Add(Chunk.NEWLINE);

                PdfPTable pdftableGeneral = new PdfPTable(GridView_Ventas.Columns.Count - 3);

                for (int j = 0; j < GridView_Ventas.Columns.Count - 1; j++)
                {
                    if (j != 0)
                    {
                        if (j != 6)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(GridView_Ventas.Columns[j].HeaderText, text));
                            cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                            pdftableGeneral.AddCell(cell);
                        }
                    }
                }

                pdftableGeneral.HeaderRows = 0;
                for (int i = 0; i < GridView_Ventas.Rows.Count; i++)
                {
                    for (int k = 0; k < GridView_Ventas.Columns.Count - 1; k++)
                    {
                        if (k != 0)
                        {
                            if (k != 6)
                            {
                                if (GridView_Ventas.Rows[i].Cells[k].Text != "&nbsp;")
                                    pdftableGeneral.AddCell(new Phrase(GridView_Ventas.Rows[i].Cells[k].Text.ToString(), text));
                                else
                                    pdftableGeneral.AddCell(new Phrase("-"));
                            }
                        }
                    }
                }

                pdfDoc.Add(pdftableGeneral);

                //Ventas detalladas
                pdfDoc.Add(Chunk.NEWLINE);
                pdfDoc.Add(new Paragraph(lblTotal.Text, text));
                pdfDoc.Add(Chunk.NEWLINE);


                pdfDoc.Close();

                Response.Write(pdfDoc);
                Response.End();


                
            }
            catch (Exception ex)
            {

                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Error del servidor.\", \"error\");", true);

            }

        }
    }
}