using Newtonsoft.Json;
using PuntoVentaCliente.WSProveedores;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PuntoVentaCliente.Vistas.Modulos
{
    public partial class Proveedores : System.Web.UI.Page
    {
        WSProveedoresSoapClient wSProveedores;
        Proveedores proveedores;

        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                proveedores = new Proveedores();
                wSProveedores = new WSProveedoresSoapClient();
                DataTable dt = (DataTable)JsonConvert.DeserializeObject(wSProveedores.ConsultarProveedores(), typeof(DataTable));
                GridView_Proveedores.DataSource = dt;

                if (!IsPostBack)
                    GridView_Proveedores.DataBind();

            }
            catch (Exception ex)
            {

                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Error del servidor.\", \"error\");", true);


            }

        }

        protected void GridView_Proveedores_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            /*
            String respuesta;

            try
            {

                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView_Animales.Rows[index];

                if (e.CommandName == "Editar")
                {

                    datosAnimales obj = new datosAnimales()
                    {

                        Id = Convert.ToInt32(row.Cells[0].Text),
                        Nombre = row.Cells[1].Text,
                        Especie = row.Cells[2].Text,
                        Pais_origen = row.Cells[3].Text,
                        Estatus = row.Cells[4].Text,
                        Peso = Convert.ToDecimal(row.Cells[5].Text),
                        Altura = Convert.ToDecimal(row.Cells[6].Text),
                        Dieta = row.Cells[7].Text,
                        Sexo = row.Cells[8].Text,
                        Nivel_riesgo = row.Cells[9].Text,
                        Id_habitad = row.Cells[10].Text,
                        Pres_prop = row.Cells[11].Text

                    };

                    Session["DataAnimales"] = obj;
                    Response.Redirect("animales_insertar-actualizar.aspx");

                }
                else if (e.CommandName == "Eliminar")
                {

                    dynamic myObject = new ExpandoObject();
                    myObject.id = Convert.ToInt32(row.Cells[0].Text);
                    string json = JsonConvert.SerializeObject(myObject);

                    respuesta = client.eliminarAnimales("[" + json + "]");

                    if (respuesta.Equals("1"))
                        Response.Redirect("animales.aspx");
                    else
                        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"No se pudo eliminar.\", \"error\");", true);


                }

            }
            catch (Exception ex)
            {

                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Error del servidor.\", \"error\");", true);


            }*/

        }

        protected void GridView_Proveedores_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView_Proveedores.PageIndex = e.NewPageIndex;
            GridView_Proveedores.DataBind();
        }

        protected void btnInsertra_Click(object sender, EventArgs e)
        {
            
        }
    }
}