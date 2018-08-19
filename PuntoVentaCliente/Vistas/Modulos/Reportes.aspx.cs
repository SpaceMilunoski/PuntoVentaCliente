using Newtonsoft.Json;
using PuntoVentaCliente.WSVentas;
using System;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using iTextSharp.text;
using iTextSharp.text.pdf;

namespace PuntoVentaCliente.Vistas.Modulos
{
    public partial class Reportes : System.Web.UI.Page
    {
        //Webservice y modelo a utilizar
        private WSVentasSoapClient wsVentas;

        private Modelos.Ventas ventas;

        private DataTable dt;

        protected void Page_Load(object sender, EventArgs e)
        {
            try {
                //Se instancian los objetos a utilizar
                ventas = new Modelos.Ventas();

                wsVentas = new WSVentasSoapClient();


                //Se carga la tabla
                cargarTabla();

                //Esto sirve para que los valores no queden estaticos al asignarlos
                if (!IsPostBack)
                {
                    GridView_Reportes.DataBind();
                    Session["Reporte"] = "Consulta";
                }
            } catch (Exception ex) {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Error del servidor.\", \"error\");", true);
            }

        }

        protected void GridView_Reportes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try {
                //Se obtiene el indice de la fila la cual se escogio
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView_Reportes.Rows[index];
                
                //Se verifica que boton se escogio si editar o eliminar
                if (e.CommandName == "VerDetalles") {

                    string json = wsVentas.DetallesVenta(Convert.ToInt32(row.Cells[0].Text));
                    dt = (DataTable)JsonConvert.DeserializeObject(json, typeof(DataTable));

                    string detalles = "";
                    int producto = 1;

                    foreach (DataRow rows in dt.Rows)
                    {
                        detalles += "Producto " + producto + " \\n ";

                        foreach (DataColumn column in dt.Columns)
                        {
                            if (column.ColumnName == "Nombre")
                                detalles += " -Nombre: " + rows[column].ToString() + " \\n ";
                            else if (column.ColumnName == "Marca")
                                detalles += " -Marca: " + rows[column].ToString() + " \\n ";
                            else if (column.ColumnName == "PrecioUnitario")
                                detalles += " -Precio Unitario: " + rows[column].ToString() + " \\n ";
                            else if (column.ColumnName == "Cantidad")
                                detalles += " -Cantidad: " + rows[column].ToString() + " \\n ";
                            else if (column.ColumnName == "PrecioTotal")
                                detalles += " -Precio total: " + rows[column].ToString() + " \\n ";

                        }

                        detalles += "\\n \\n";
                        producto++;

                    }
                    

                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\" " + detalles + " \");", true);

                }

            } catch (Exception ex) {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Error del servidor.\", \"error\");", true);
            }
        }

        protected void GridView_Reportes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView_Reportes.PageIndex = e.NewPageIndex;
            GridView_Reportes.DataBind();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            if (ddlTipoBusqueda.SelectedValue == "Empleado" && txtbEmpleado.Text == "")
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Warning\", \"Introduzca el nombre del empleado.\", \"warning\");", true);
                return;
            }
            else if (ddlTipoBusqueda.SelectedValue == "Fecha" && (txtbFechaInicio.Text == "" || txtbFechaFinal.Text == ""))
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Warning\", \"Introduzca la fecha inicial y final.\", \"warning\");", true);
                return;
            }

            Session["Empleado"] = txtbEmpleado.Text;
            Session["FechaInicial"] = txtbFechaInicio.Text;
            Session["FechaFinal"] = txtbFechaFinal.Text;

            //Se llena la tabla con los datos obtenidos del metodo buscar en el servicio web
            dt = (DataTable)JsonConvert.DeserializeObject(wsVentas.BuscarVentas(txtbEmpleado.Text,txtbFechaInicio.Text,txtbFechaFinal.Text), typeof(DataTable));
            GridView_Reportes.DataSource = dt;

            //Se llena el datagridview
            GridView_Reportes.DataBind();

            Session["Reporte"] = "Busqueda";
        }

        protected void btnPDF_Click(object sender, EventArgs e)
        {
            try
            {
                
                //Datos tabla general                
                if (Convert.ToString(Session["Reporte"]) == "Busqueda")
                    dt = (DataTable)JsonConvert.DeserializeObject(wsVentas.BuscarVentas(Convert.ToString(Session["Empleado"]), Convert.ToString(Session["FechaInicio"]), Convert.ToString(Session["FechaFinal"])), typeof(DataTable));
                else
                    dt = (DataTable)GridView_Reportes.DataSource;

                GridView_Reportes.DataSource = dt;
                GridView_Reportes.DataBind();

                //Datos tabla detalles
                DataTable aux = new DataTable();

                for(int i=0; i<GridView_Reportes.Rows.Count; i++)
                {
                    string json = wsVentas.DetallesVenta(Convert.ToInt32(GridView_Reportes.Rows[i].Cells[0].Text));
                    dt = (DataTable)JsonConvert.DeserializeObject(json, typeof(DataTable));

                    if (i == 0)
                        aux = dt.Clone();

                    foreach(DataRow row in dt.Rows)
                    {
                        aux.Rows.Add(row.ItemArray);
                    }

                }

                GridView_Detalles.DataSource = aux;
                GridView_Detalles.DataBind();

                //Generar pdf

                Response.ContentType = "application/pdf";
                Response.AddHeader("content-disposition", "attachment;filename=Reporte " + System.DateTime.Now.ToString("dd_MM_yyyy HH_mm_ss") + ".pdf");
                Response.Cache.SetCacheability(HttpCacheability.NoCache);
                
                Document pdfDoc = new Document(PageSize.LETTER);

                PdfWriter.GetInstance(pdfDoc, Response.OutputStream);

                pdfDoc.Open();

                iTextSharp.text.Font text = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 11);


                pdfDoc.Add(new Paragraph("Reporte de ventas"));
                pdfDoc.Add(Chunk.NEWLINE);
                pdfDoc.Add(new Paragraph("Fecha y hora de emision: " + System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") , text));
                pdfDoc.Add(Chunk.NEWLINE);
                pdfDoc.Add(new Paragraph("Reporte de tipo: " + ddlTipoBusqueda.SelectedValue, text));
                pdfDoc.Add(Chunk.NEWLINE);

                //Ventas generales
                pdfDoc.Add(Chunk.NEWLINE);
                pdfDoc.Add(new Paragraph("Ventas generales ", text));
                pdfDoc.Add(Chunk.NEWLINE);

                PdfPTable pdftableGeneral = new PdfPTable(GridView_Reportes.Columns.Count - 1);

                for (int j = 0; j < GridView_Reportes.Columns.Count - 1; j++)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(GridView_Reportes.Columns[j].HeaderText, text));
                    cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                    pdftableGeneral.AddCell(cell);
                }
                
                pdftableGeneral.HeaderRows = 0;
                for (int i = 0; i < GridView_Reportes.Rows.Count; i++)

                {
                    for (int k = 0; k < GridView_Reportes.Columns.Count - 1; k++)
                    {

                        if (GridView_Reportes.Rows[i].Cells[k].Text != "&nbsp;")
                        {
                            pdftableGeneral.AddCell(new Phrase(GridView_Reportes.Rows[i].Cells[k].Text.ToString(), text));
                            //pdftable.AddCell(new Phrase(dgvLoadAll[k, i].Value.ToString(), text));

                        }
                        else
                            pdftableGeneral.AddCell(new Phrase("-"));
                    }

                    
                }

                pdfDoc.Add(pdftableGeneral);

                //Ventas detalladas

                pdfDoc.Add(Chunk.NEWLINE);
                pdfDoc.Add(new Paragraph("Detalles de ventas ", text));
                pdfDoc.Add(Chunk.NEWLINE);

                PdfPTable pdftableDetalles = new PdfPTable(GridView_Detalles.Columns.Count);

                for (int j = 0; j < GridView_Detalles.Columns.Count; j++)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(GridView_Detalles.Columns[j].HeaderText, text));
                    cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                    pdftableDetalles.AddCell(cell);
                }

                pdftableDetalles.HeaderRows = 0;
                for (int i = 0; i < GridView_Detalles.Rows.Count; i++)

                {
                    for (int k = 0; k < GridView_Detalles.Columns.Count; k++)
                    {

                        if (GridView_Detalles.Rows[i].Cells[k].Text != "&nbsp;")
                        {
                            pdftableDetalles.AddCell(new Phrase(GridView_Detalles.Rows[i].Cells[k].Text.ToString(), text));
                            //pdftable.AddCell(new Phrase(dgvLoadAll[k, i].Value.ToString(), text));

                        }
                        else
                            pdftableDetalles.AddCell(new Phrase("-"));
                    }


                }

                pdfDoc.Add(pdftableDetalles);
                
                pdfDoc.Close();

                Response.Write(pdfDoc);
                Response.End();

            }
            catch (Exception ex)
            {

                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Error del servidor.\", \"error\");", true);

            }
        }

        //Se utiliza para no repetir el codigo, ya que se utiliza en algunas partes
        private void cargarTabla()
        {
            dt = (DataTable)JsonConvert.DeserializeObject(wsVentas.ConsultarVentas(), typeof(DataTable));
            GridView_Reportes.DataSource = dt;
        }

        //Este metodo actualiza los datos de la tabla
        private void actualizacionTabla()
        {
            cargarTabla();
            GridView_Reportes.DataBind();
        }

        protected void ddlTipoBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlTipoBusqueda.SelectedValue == "Empleado") {
                txtbEmpleado.Visible = true;
                lblEmpleado.Visible = true;

                txtbFechaInicio.Visible = false;
                txtbFechaFinal.Visible = false;
                lblDe.Visible = false;
                lblA.Visible = false;

            }
            else if (ddlTipoBusqueda.SelectedValue == "Fecha") {
                txtbFechaInicio.Visible = true;
                txtbFechaFinal.Visible = true;
                lblDe.Visible = true;
                lblA.Visible = true;

                txtbEmpleado.Visible = false;
                lblEmpleado.Visible = false;
            }
        }
    }
}