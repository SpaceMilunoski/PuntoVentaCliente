using Newtonsoft.Json;
using PuntoVentaCliente.Modelos;
using PuntoVentaCliente.WSDepartamentos;
using PuntoVentaCliente.WSEmpleados;
using PuntoVentaCliente.WSPuestos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PuntoVentaCliente.Vistas.Modulos
{
    public partial class Empleados : System.Web.UI.Page
    {
        private WSEmpleadosSoapClient wsEmpleados;
        private WSDepartamentosSoapClient wsDepartamentos;
        private WSPuestosSoapClient wsPuestos;

        private Modelos.Empleados empleados;
        private Modelos.Usuarios usuarios;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                empleados = new Modelos.Empleados();
                usuarios = new Modelos.Usuarios();

                wsEmpleados = new WSEmpleadosSoapClient();
                wsDepartamentos = new WSDepartamentosSoapClient();
                wsPuestos = new WSPuestosSoapClient();

                cargarTabla();

                if (!IsPostBack)
                {
                    GridView_Empleados.DataBind();
                    btnInsertar.Text = "Agregar";

                    ocultarCampos();

                    txtId_Usuario.Text = "0";
                    txtbId_Empleado.Text = "0";
                    txtbEmpleados_Id.Text = "0";

                    llenarDropList();
                }

            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Error del servidor.\", \"error\");", true);
            }
        }

        private void llenarDropList()
        {

            try
            {
                DataTable dt;

                string jsonPuestos = wsPuestos.ConsultarPuestos();
                dt = (DataTable)JsonConvert.DeserializeObject(jsonPuestos, typeof(DataTable));

                foreach (DataRow row in dt.Rows)
                {
                    string descripcion = Convert.ToString(row["Puesto"]);
                    ddlPuestos.Items.Add(descripcion);
                }

                string jsonDepartamentos = wsDepartamentos.ConsultarDepartamentos();
                dt = (DataTable)JsonConvert.DeserializeObject(jsonDepartamentos, typeof(DataTable));

                foreach (DataRow row in dt.Rows)
                {
                    string descripcion = Convert.ToString(row["Departamento"]);
                    ddlDepartamentos.Items.Add(descripcion);
                }

            }
            catch (Exception ex)
            {
                Response.Write("<script language=javascript> alert('" + ex.Message + "'); </script>");
            }

        }
        
        private void cargarTabla()
        {
            string json = wsEmpleados.ConsultarEmpleados(Convert.ToString(Session["User"]));
            DataTable dt = (DataTable)JsonConvert.DeserializeObject(json, typeof(DataTable));
            GridView_Empleados.DataSource = dt;
        }

        protected void GridView_Empleados_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {

                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView_Empleados.Rows[index];


                txtbId_Empleado.Text = Convert.ToString(row.Cells[0].Text);

                if (e.CommandName == "Editar")
                {

                    txtbNombre.Text = row.Cells[1].Text;
                    txtbApellido.Text = row.Cells[2].Text;
                    txtbTelefono.Text = row.Cells[3].Text;
                    txtbFechaIngreso.Text = row.Cells[4].Text;
                    ddlDepartamentos.SelectedValue = row.Cells[5].Text;
                    ddlPuestos.SelectedValue = row.Cells[6].Text;


                    if (!row.Cells[8].Text.Equals("&nbsp;"))
                    {
                        txtId_Usuario.Text = row.Cells[7].Text;
                        txtbUsuario.Text = row.Cells[8].Text;
                        txtbPassword.Text = row.Cells[9].Text;
                        ddlPrivilegios.SelectedValue = row.Cells[10].Text;
                        txtbEmpleados_Id.Text = row.Cells[11].Text;
                    }
                    else
                        txtbUsuario.Text = "";
                    

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

        protected void GridView_Empleados_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView_Empleados.PageIndex = e.NewPageIndex;
            GridView_Empleados.DataBind();
        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            if ( (txtbUsuario.Text != "" && (txtbPassword.Text == "" || txtbPasswordRepetir.Text == "")) ||
                 (txtbPassword.Text != "" && (txtbUsuario.Text == "" || txtbPasswordRepetir.Text == "")) ||
                 (txtbPasswordRepetir.Text != "" && (txtbPassword.Text == "" || txtbUsuario.Text == "")) ) {

                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Warning\", \"Si quiere asignar un usuario coloque el nombre de usuario, contraseña y los privilegios correspondientes.\", \"warning\");", true);
                return;
            }

            if (txtbNombre.Text != "" && txtbApellido.Text != "" && txtbTelefono.Text != "" && txtbFechaIngreso.Text != "" ) {

                if (txtbPassword.Text == txtbPasswordRepetir.Text) {

                    string password = Encryption.encrypt(txtbPassword.Text);

                    empleados.Id = Convert.ToInt16(txtbId_Empleado.Text);
                    empleados.Nombre = txtbNombre.Text;
                    empleados.Apellido = txtbApellido.Text;
                    empleados.Telefono = txtbTelefono.Text;
                    empleados.FechaIngreso = txtbFechaIngreso.Text;
                    empleados.Departamento = ddlDepartamentos.SelectedValue;
                    empleados.Puesto = ddlPuestos.SelectedValue;

                    usuarios.Id = Convert.ToInt16(txtId_Usuario.Text);
                    usuarios.Usuario = txtbUsuario.Text;
                    usuarios.Password = password;
                    usuarios.Privilegios = ddlPrivilegios.SelectedValue;
                    usuarios.Empleados_Id = empleados.Id;

                    String jsonEmpleado = JsonConvert.SerializeObject(empleados);
                    String jsonUsuario = JsonConvert.SerializeObject(usuarios);

                    if (btnInsertar.Text == "Agregar")
                    {

                        if (wsEmpleados.InsertarEmpleados(jsonEmpleado, jsonUsuario))
                        {
                            ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Successful\", \"Operacion realizada con exito.\", \"success\");", true);

                            mostrarCampos();

                            cargarTabla();
                            GridView_Empleados.DataBind();

                            ocultarCampos();

                        }
                        else
                            ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Error del servidor.\", \"error\");", true);

                    }
                    else if (btnInsertar.Text == "Actualizar")
                    {
                        
                        if ( wsEmpleados.ActualizarEmpleado(jsonEmpleado, jsonUsuario))
                        {
                            ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Successful\", \"Operacion realizada con exito.\", \"success\");", true);

                            mostrarCampos();

                            cargarTabla();
                            GridView_Empleados.DataBind();

                            ocultarCampos();

                        }
                        else
                            ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Error del servidor.\", \"error\");", true);

                        btnInsertar.Text = "Agregar";
                        
                    }

                    txtbNombre.Text = string.Empty;
                    txtbApellido.Text = string.Empty;
                    txtbTelefono.Text = string.Empty;
                    txtbFechaIngreso.Text = string.Empty;
                    txtbUsuario.Text = string.Empty;
                    txtbPassword.Text = string.Empty;
                    txtbPasswordRepetir.Text = string.Empty;

                } else
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Aviso\", \"La nueva contraseña no coincide en ambos campos.\", \"warning\");", true);
                
            }
            else
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Warning\", \"Llene los campos obligatorios (*).\", \"warning\");", true);
            
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                mostrarCampos();

                DataTable dt = (DataTable)JsonConvert.DeserializeObject(wsEmpleados.BuscarEmpleado(txtbBusqueda.Text, Convert.ToString(Session["User"])), typeof(DataTable));
                GridView_Empleados.DataSource = dt;

                GridView_Empleados.DataBind();

                ocultarCampos();

                txtbBusqueda.Text = string.Empty;
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Error del servidor.\", \"error\");", true);
            }
        }

        private void mostrarCampos()
        {
            GridView_Empleados.Columns[0].Visible = true;
            GridView_Empleados.Columns[7].Visible = true;
            GridView_Empleados.Columns[9].Visible = true;
            GridView_Empleados.Columns[11].Visible = true;
        }

        private void ocultarCampos()
        {
            GridView_Empleados.Columns[0].Visible = false;
            GridView_Empleados.Columns[7].Visible = false;
            GridView_Empleados.Columns[9].Visible = false;
            GridView_Empleados.Columns[11].Visible = false;
        }

    }
}