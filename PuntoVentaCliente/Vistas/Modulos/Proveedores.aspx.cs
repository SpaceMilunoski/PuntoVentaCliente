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
        //Web service y modelo a utilizar
        private WSProveedoresSoapClient wsProveedores;
        private Modelos.Proveedores proveedores;

        protected void Page_Load(object sender, EventArgs e)
        {

            try {
                
                //Inicializar los objetos
                proveedores = new Modelos.Proveedores();
                wsProveedores = new WSProveedoresSoapClient();

                //Cargar la tabla con los datos
                cargarTabla();

                if (!IsPostBack) {

                    //Enlazar los datos al datagridview
                    GridView_Proveedores.DataBind();
                    btnInsertar.Text = "Agregar Proveedor";

                    ocultarCampos();

                    txtbId.Text = "0";
                }
                
            } catch (Exception ex) {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Error del servidor.\", \"error\");", true);
            }

        }

        #region Insertar, Actualizar, Eliminar y Buscar

        //Evento el cual recupera los datos de la tabla y los carga en los campos correspondiemtes, ademas este evento sirve para eliminar al proveedor
        protected void GridView_Proveedores_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try {
                
                //Se obtiene el indice de la fila seleccionada
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView_Proveedores.Rows[index];
                
                //Se verifica si se oprimio el boton de editar o de eliminar
                if (e.CommandName == "Editar") {

                    //se asigna cada valor de la tabla con su respectivo textbox
                    txtbId.Text = Convert.ToString(row.Cells[0].Text);
                    txtbRazonSocial.Text = row.Cells[1].Text;
                    txtbDireccionFiscal.Text = row.Cells[2].Text;
                    txtbDireccionUbicacion.Text = row.Cells[3].Text;
                    txtbRfc.Text = row.Cells[4].Text;
                    txtbNombreContacto.Text = row.Cells[5].Text;
                    txtbTelefono.Text = row.Cells[6].Text;
                    txtbCorreo.Text = row.Cells[7].Text;

                    btnInsertar.Text = "Actualizar Proveedor";
                    
                } else if (e.CommandName == "Eliminar") {
                   
                    //Se manda llamar el metodo de eliminar y se le manda como parametro el id a eliminar
                    if (wsProveedores.EliminarProveedores(Convert.ToInt32(row.Cells[0].Text))) {
                        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Successful\", \"Operacion realizada con exito.\", \"success\");", true);
                        actualizarTabla();
                    } else
                        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Error del servidor.\", \"error\");", true);
                    
                }

            } catch (Exception ex) {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Error del servidor.\", \"error\");", true);
            }

        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            //Se verifica que todos los campos esten con informacion
            if (txtbRazonSocial.Text != "" && txtbDireccionFiscal.Text != "" && txtbDireccionUbicacion.Text !="" && 
                txtbRfc.Text !="" && txtbNombreContacto.Text !="" && txtbTelefono.Text !="" && txtbCorreo.Text !="") {

                //Se asigna los valores a al respectivo modelo
                proveedores.Id = Convert.ToInt32(txtbId.Text);
                proveedores.RazonSocial = txtbRazonSocial.Text;
                proveedores.DireccionFiscal = txtbDireccionFiscal.Text;
                proveedores.DireccionUbicacion = txtbDireccionUbicacion.Text;
                proveedores.Rfc = txtbRfc.Text;
                proveedores.NombreContacto = txtbNombreContacto.Text;
                proveedores.Telefono = txtbTelefono.Text;
                proveedores.Correo = txtbCorreo.Text;

                //Se serializa el objeto a neviar
                String json = JsonConvert.SerializeObject(proveedores);

                //Se identifica si se agregara al preoveedor o solo se actualizara
                if (btnInsertar.Text == "Agregar Proveedor") {

                    //Se manda llamar el metodo de insertar y como parametros el JSON 
                    if (wsProveedores.InsertarProveedores(json)) {
                        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Successful\", \"Operacion realizada con exito.\", \"success\");", true);
                        actualizarTabla();
                    } else
                        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Error del servidor.\", \"error\");", true);

                } else if (btnInsertar.Text == "Actualizar Proveedor") {

                    //Se manda llamar el metodo de actualizar y como parametros el JSON 
                    if (wsProveedores.ActualizarProveedores(json)) {
                        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Successful\", \"Operacion realizada con exito.\", \"success\");", true);
                        actualizarTabla();
                    } else
                        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Error del servidor.\", \"error\");", true);

                    btnInsertar.Text = "Agregar Proveedor";
                }
                
                //Se vacian los campos para posteriores operaciones
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

        //Evento el cual busca al proveedor ya sea por Razon social o por RFC
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try {

                mostrarCampos();

                //Se cargan los datos de busqueda, se llena y se enlaza con el datagridview
                DataTable dt = (DataTable)JsonConvert.DeserializeObject(wsProveedores.BuscarProveedores(txtbBusqueda.Text), typeof(DataTable));
                GridView_Proveedores.DataSource = dt;
                
                GridView_Proveedores.DataBind();

                ocultarCampos();

                txtbBusqueda.Text = string.Empty;

            } catch (Exception ex) {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Error del servidor.\", \"error\");", true);
            }
        }
        #endregion

        #region Metodos para la tabla

        //Se creo este metodo ya que se utiliza varias veces este codigo
        private void cargarTabla()
        {
            DataTable dt = (DataTable)JsonConvert.DeserializeObject(wsProveedores.ConsultarProveedores(), typeof(DataTable));
            GridView_Proveedores.DataSource = dt;
        }

        //Muestra los campos para que asi se almacene la informacion y no se pierda por los problemas de asp.net
        private void mostrarCampos()
        {
            GridView_Proveedores.Columns[0].Visible = true;
        }

        //Se ocultan los campos para mejorar la estetica
        private void ocultarCampos()
        {
            GridView_Proveedores.Columns[0].Visible = false;
        }

        //Actualiza la tabla despues de hacer cambios en ella
        private void actualizarTabla()
        {
            mostrarCampos();

            cargarTabla();
            GridView_Proveedores.DataBind();

            ocultarCampos();
        }

        //Este evento es el que cambia cambia la paginacion del datagridview
        protected void GridView_Proveedores_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView_Proveedores.PageIndex = e.NewPageIndex;
            GridView_Proveedores.DataBind();
        }
        #endregion

    }
}