using Newtonsoft.Json;
using PuntoVentaCliente.WSProveedores;
using PuntoVentaCliente.Modelos;
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
        private WSProveedoresSoapClient wsProveedores;
        private Modelos.Proveedores proveedores;

        protected void Page_Load(object sender, EventArgs e)
        {

            try {
                proveedores = new Modelos.Proveedores();
                wsProveedores = new WSProveedoresSoapClient();

                cargarTabla();

                if (!IsPostBack) {
                    GridView_Proveedores.DataBind();
                    btnInsertar.Text = "Agregar";
                }

            } catch (Exception ex) {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Error del servidor.\", \"error\");", true);
            }

        }

        private void cargarTabla()
        {
            DataTable dt = (DataTable)JsonConvert.DeserializeObject(wsProveedores.ConsultarProveedores(), typeof(DataTable));
            GridView_Proveedores.DataSource = dt;
        }

        protected void GridView_Proveedores_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {

                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView_Proveedores.Rows[index];


                txtbId.Text = Convert.ToString(row.Cells[0].Text);

                if (e.CommandName == "Editar")
                {

                    txtbRazonSocial.Text = row.Cells[1].Text;
                    txtbDireccionFiscal.Text = row.Cells[2].Text;
                    txtbDireccionUbicacion.Text = row.Cells[3].Text;
                    txtbRfc.Text = row.Cells[4].Text;
                    txtbNombreContacto.Text = row.Cells[5].Text;
                    txtbTelefono.Text = row.Cells[6].Text;
                    txtbCorreo.Text = row.Cells[7].Text;

                    btnInsertar.Text = "Actualizar";
                    
                }
                else if (e.CommandName == "Eliminar")
                {
                    Console.Write("Borrar");                  
                }

            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Error del servidor.\", \"error\");", true);
            }

        }

        protected void GridView_Proveedores_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView_Proveedores.PageIndex = e.NewPageIndex;
            GridView_Proveedores.DataBind();
        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            if (txtbRazonSocial.Text != "" && txtbDireccionFiscal.Text != "" && txtbDireccionUbicacion.Text !="" && 
                txtbRfc.Text !="" && txtbNombreContacto.Text !="" && txtbTelefono.Text !="" && txtbCorreo.Text !="") {

                proveedores.Id = Convert.ToInt32(txtbId.Text);
                proveedores.RazonSocial = txtbRazonSocial.Text;
                proveedores.DireccionFiscal = txtbDireccionFiscal.Text;
                proveedores.DireccionUbicacion = txtbDireccionUbicacion.Text;
                proveedores.Rfc = txtbRfc.Text;
                proveedores.NombreContacto = txtbNombreContacto.Text;
                proveedores.Telefono = txtbTelefono.Text;
                proveedores.Correo = txtbCorreo.Text;

                String json = JsonConvert.SerializeObject(proveedores);

                if (btnInsertar.Text == "Agregar") {

                    if (wsProveedores.InsertarProveedores(json))
                        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Successful\", \"Operacion realizada con exito.\", \"success\");", true);
                    else
                        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Error del servidor.\", \"error\");", true);

                } else if (btnInsertar.Text == "Actualizar") {

                    if (wsProveedores.ActualizarProveedores(json)) {
                        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Successful\", \"Operacion realizada con exito.\", \"success\");", true);
                        cargarTabla();
                        GridView_Proveedores.DataBind();
                    } else
                        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Error del servidor.\", \"error\");", true);

                    btnInsertar.Text = "Agregar";
                }

                txtbRazonSocial.Text = string.Empty;
                txtbDireccionFiscal.Text = string.Empty;
                txtbDireccionUbicacion.Text = string.Empty;
                txtbRfc.Text = string.Empty;
                txtbNombreContacto.Text = string.Empty;
                txtbTelefono.Text = string.Empty;
                txtbCorreo.Text = string.Empty;


            } else
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Warning\", \"Llene todos los campos.\", \"warning\");", true);

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = (DataTable)JsonConvert.DeserializeObject(wsProveedores.BuscarProveedores(txtbBusqueda.Text), typeof(DataTable));
                GridView_Proveedores.DataSource = dt;
                
                GridView_Proveedores.DataBind();

                txtbBusqueda.Text = string.Empty;
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Error del servidor.\", \"error\");", true);
            }
        }
    }
}