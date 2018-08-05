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
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PuntoVentaCliente.Vistas.Modulos
{
    public partial class Empleados : System.Web.UI.Page
    {
        //Webservice a utilizar
        private WSEmpleadosSoapClient wsEmpleados;
        private WSDepartamentosSoapClient wsDepartamentos;
        private WSPuestosSoapClient wsPuestos;

        //Modelos a utilizar
        private Modelos.Empleados empleados;
        private Modelos.Usuarios usuarios;

        protected void Page_Load(object sender, EventArgs e)
        {
            try {
                //Se instancian los objetos a utilizar
                empleados = new Modelos.Empleados();
                usuarios = new Modelos.Usuarios();

                wsEmpleados = new WSEmpleadosSoapClient();
                wsDepartamentos = new WSDepartamentosSoapClient();
                wsPuestos = new WSPuestosSoapClient();

                //Se carga la tabla
                cargarTabla();

                //Esto sirve para que los valores no queden estaticos al asignarlos
                if (!IsPostBack) {
                    GridView_Empleados.DataBind();
                    btnInsertar.Text = "Agregar Empleado";

                    ocultarCampos();

                    txtId_Usuario.Text = "0";
                    txtbId_Empleado.Text = "0";
                    txtbEmpleados_Id.Text = "0";

                    llenarDropListDepartamento();
                    llenarDropListPuestos();
                }

            } catch (Exception ex) {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Error del servidor.\", \"error\");", true);
            }
        }

        #region Editar, Insertar, Eliminar y Buscar

        //Evento el cual recupera los datos de la tabla y los carga en los campos correspondiemtes, ademas este evento sirve para eliminar al empleado
        protected void GridView_Empleados_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try {
                //Se obtiene el indice de la fila la cual se escogio
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView_Empleados.Rows[index];
                
                //Se verifica que boton se escogio si editar o eliminar
                if (e.CommandName == "Editar") {

                    //Se cargan los datos de la tabla en los textbox
                    txtbId_Empleado.Text = Convert.ToString(row.Cells[0].Text);
                    txtbNombre.Text = row.Cells[1].Text;
                    txtbApellido.Text = row.Cells[2].Text;
                    txtbTelefono.Text = row.Cells[3].Text;
                    txtbFechaIngreso.Text = row.Cells[4].Text;
                    ddlDepartamentos.SelectedValue = row.Cells[5].Text;
                    ddlPuestos.SelectedValue = row.Cells[6].Text;

                    //Si los datos no estan vacios se cargan los demas datos (en el datagridview viene po defecto &nbsp; para indicar que esta vacia la celda)
                    if (!row.Cells[8].Text.Equals("&nbsp;")) {
                        txtId_Usuario.Text = row.Cells[7].Text;
                        txtbUsuario.Text = row.Cells[8].Text;
                        txtbPassword.Text = row.Cells[9].Text;
                        ddlPrivilegios.SelectedValue = row.Cells[10].Text;
                        txtbEmpleados_Id.Text = row.Cells[11].Text;
                    } else
                        txtbUsuario.Text = "";


                    btnInsertar.Text = "Actualizar Empleado";

                } else if (e.CommandName == "Eliminar") {
                    
                    //Se elimina el empleado seleccionado y se actualiza la tabla
                    if(wsEmpleados.EliminarEmpleado(Convert.ToInt32(row.Cells[0].Text))) {
                        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Successful\", \"Operacion realizada con exito.\", \"success\");", true);
                        actualizacionTabla();
                    } else
                        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Error del servidor.\", \"error\");", true);

                }

            } catch (Exception ex) {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Error del servidor.\", \"error\");", true);
            }
        }
        
        //Evento para insertar o actualizar un empleado
        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            //Se verifica si se quiere agregar un usuario al empleado, ya que si lo hace tiene que llenar los campos dedicdos para eso
            if ((txtbUsuario.Text != "" && (txtbPassword.Text == "" || txtbPasswordRepetir.Text == "")) ||
                 (txtbPassword.Text != "" && (txtbUsuario.Text == "" || txtbPasswordRepetir.Text == "")) ||
                 (txtbPasswordRepetir.Text != "" && (txtbPassword.Text == "" || txtbUsuario.Text == ""))) {

                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Warning\", \"Si quiere asignar un usuario coloque el nombre de usuario, contraseña y los privilegios correspondientes.\", \"warning\");", true);
                return;
            }

            //Se verifica que se hayan llenado los campos obligatorios
            if (txtbNombre.Text != "" && txtbApellido.Text != "" && txtbTelefono.Text != "" && txtbFechaIngreso.Text != "") {

                //Se verifica que los dos campos de contraseña sean iguales
                if (txtbPassword.Text == txtbPasswordRepetir.Text) {

                    //Se encipta la contraseña
                    string password = Encryption.encrypt(txtbPassword.Text);

                    //Se capturan los datos de los textbox en sus respectivos modelos
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

                    //Se serializan los modelos a JSON
                    String jsonEmpleado = JsonConvert.SerializeObject(empleados);
                    String jsonUsuario = JsonConvert.SerializeObject(usuarios);

                    //Se verifica si se desea insertar o actualizar
                    if (btnInsertar.Text == "Agregar Empleado") {
                        //Se mandan los JSON por el metodo de insertar
                        if (wsEmpleados.InsertarEmpleados(jsonEmpleado, jsonUsuario)) {
                            ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Successful\", \"Operacion realizada con exito.\", \"success\");", true);
                            actualizacionTabla();
                        } else
                            ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Error del servidor.\", \"error\");", true);

                    } else if (btnInsertar.Text == "Actualizar Empleado") {
                        //Se mandadn los JSON por el metodo de actualizar
                        if (wsEmpleados.ActualizarEmpleado(jsonEmpleado, jsonUsuario)) {
                            ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Successful\", \"Operacion realizada con exito.\", \"success\");", true);
                            actualizacionTabla();
                        } else
                            ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Error del servidor.\", \"error\");", true);

                        btnInsertar.Text = "Agregar Empleado";
                    }

                    //Se vacian de nuevo los campos
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

        //Evento para buscar un empleado ya sea por nombre o apellido
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try {
                
                mostrarCampos();

                //Se llena la tabla con los datos obtenidos del metodo buscar en el servicio web
                DataTable dt = (DataTable)JsonConvert.DeserializeObject(wsEmpleados.BuscarEmpleado(txtbBusqueda.Text, Convert.ToString(Session["User"])), typeof(DataTable));
                GridView_Empleados.DataSource = dt;

                //Se llena el datagridview
                GridView_Empleados.DataBind();
                
                ocultarCampos();

                txtbBusqueda.Text = string.Empty;
            } catch (Exception ex) {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Error del servidor.\", \"error\");", true);
            }
        }

        #endregion

        #region Metodos auxiliares para la tabla

        //Se utiliza para no repetir el codigo, ya que se utiliza en algunas partes
        private void cargarTabla()
        {
            string json = wsEmpleados.ConsultarEmpleados(Convert.ToString(Session["User"]));
            DataTable dt = (DataTable)JsonConvert.DeserializeObject(json, typeof(DataTable));
            GridView_Empleados.DataSource = dt;
        }

        //Esto metodo sirve para que cuando se cargue la tabla se guarden todos los datos, ya que si estan invisibles no se guardan
        private void mostrarCampos()
        {
            GridView_Empleados.Columns[0].Visible = true;
            GridView_Empleados.Columns[7].Visible = true;
            GridView_Empleados.Columns[9].Visible = true;
            GridView_Empleados.Columns[11].Visible = true;
        }

        //En este metodo hacemos invisibles los campo una vez cargados los datos (los doatos no se borraran), esto sirve para darle estetica a la tabla
        private void ocultarCampos()
        {
            GridView_Empleados.Columns[0].Visible = false;
            GridView_Empleados.Columns[7].Visible = false;
            GridView_Empleados.Columns[9].Visible = false;
            GridView_Empleados.Columns[11].Visible = false;
        }

        //Este metodo actualiza los datos de la tabla
        private void actualizacionTabla()
        {
            mostrarCampos();

            cargarTabla();
            GridView_Empleados.DataBind();

            ocultarCampos();
        }

        //Este evento sirve para poder cambiar de paginacion en la tabla
        protected void GridView_Empleados_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView_Empleados.PageIndex = e.NewPageIndex;
            GridView_Empleados.DataBind();
        }
        #endregion

        #region Departamentos

        //Eventos para agregar departamento
        protected void btnAgregarDepartamento_Click(object sender, EventArgs e)
        {
            //Condicion ya que el boton tiene dos modalidades, la primera es cambiar el dropdownlist por un textbox y la segunda es agregar el departamento a la base de datos 
            if (btnAgregarDepartamento.Text == "Nuevo Dpto.") {

                btnAgregarDepartamento.Text = "Agregar Dpto.";
                txtbDepartamento.Visible = true;
                ddlDepartamentos.Visible = false;
                btnEliminarDepartamento.Text = "Cancelar";

            } else {

                if (txtbDepartamento.Text != "") {

                    if (wsDepartamentos.InsertarDepartamento(txtbDepartamento.Text)) { 
                        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Successful\", \"Operacion realizada con exito.\", \"success\");", true);

                        ddlDepartamentos.Items.Clear();
                        llenarDropListDepartamento();

                        btnAgregarDepartamento.Text = "Nuevo Dpto.";
                        txtbDepartamento.Visible = false;
                        ddlDepartamentos.Visible = true;
                        btnEliminarDepartamento.Text = "Eliminar Dpto.";

                        txtbDepartamento.Text = "";
                    } else
                        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Error del servidor.\", \"error\");", true);

                }
            }
        }

        //Evento para eliminar un departamento
        protected void btnEliminarDepartamento_Click(object sender, EventArgs e)
        {
            //Condicion ya que el boton tiene dos modalidades, la primera es eliminar el departamento de la base de datos y el segundo cancelar la operacion cuando se quiere agregar un departamento
            if (btnEliminarDepartamento.Text == "Eliminar Dpto.")
            {
                if (wsDepartamentos.EliminarDepartamento(ddlDepartamentos.SelectedValue)) {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Successful\", \"Operacion realizada con exito.\", \"success\");", true);

                    ddlDepartamentos.Items.Clear();
                    llenarDropListDepartamento();

                } else
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Error del servidor.\", \"error\");", true);
                
            } else if (btnEliminarDepartamento.Text == "Cancelar") {

                btnAgregarDepartamento.Text = "Nuevo Dpto.";
                txtbDepartamento.Visible = false;
                ddlDepartamentos.Visible = true;
                btnEliminarDepartamento.Text = "Eliminar Dpto.";
            }
        }

        //Este metodo sirve para llenar el dropdownlist de departamentos, ya sea al inicio o cuando se hace algun cambio
        private void llenarDropListDepartamento()
        {
            try {

                //Se obtienen los datos y se almacenan en una tabla
                string jsonDepartamentos = wsDepartamentos.ConsultarDepartamentos();
                DataTable dt = (DataTable)JsonConvert.DeserializeObject(jsonDepartamentos, typeof(DataTable));

                //Se recorre la tabla y se llena el dropdownlist
                foreach (DataRow row in dt.Rows) {
                    string descripcion = Convert.ToString(row["Departamento"]);
                    ddlDepartamentos.Items.Add(descripcion);
                }

            } catch (Exception ex) {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Error del servidor.\", \"error\");", true);
            }

        }
        #endregion

        #region Puestos

        //Eventos para agregar puesto
        protected void btnAgregarPuesto_Click(object sender, EventArgs e)
        {
            //Condicion ya que el boton tiene dos modalidades, la primera es cambiar el dropdownlist por un textbox y la segunda es agregar el puesto a la base de datos 
            if (btnAgregarPuesto.Text == "Nuevo Puesto") {

                btnAgregarPuesto.Text = "Agregar Puesto";
                txtbPuesto.Visible = true;
                ddlPuestos.Visible = false;
                btnEliminarPuesto.Text = "Cancelar";

            } else {

                if (txtbPuesto.Text != "") {

                    if (wsPuestos.InsertarPuesto(txtbPuesto.Text)) { 
                        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Successful\", \"Operacion realizada con exito.\", \"success\");", true);

                        ddlPuestos.Items.Clear();
                        llenarDropListPuestos();

                        btnAgregarPuesto.Text = "Nuevo Puesto";
                        txtbPuesto.Visible = false;
                        ddlPuestos.Visible = true;
                        btnEliminarPuesto.Text = "Eliminar Puesto";

                        txtbPuesto.Text = "";
                    } else
                        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Error del servidor.\", \"error\");", true);

                }
            }
        }

        //Evento para eliminar un puesto
        protected void btnEliminarPuesto_Click(object sender, EventArgs e)
        {
            //Condicion ya que el boton tiene dos modalidades, la primera es eliminar el puesto de la base de datos y el segundo cancelar la operacion cuando se quiere agregar un puesto
            if (btnEliminarPuesto.Text == "Eliminar Puesto") {

                if (wsPuestos.EliminarPuesto(ddlPuestos.SelectedValue)) {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Successful\", \"Operacion realizada con exito.\", \"success\");", true);

                    ddlPuestos.Items.Clear();
                    llenarDropListPuestos();

                } else
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Error del servidor.\", \"error\");", true);
                
            } else if (btnEliminarPuesto.Text == "Cancelar") {

                btnAgregarPuesto.Text = "Nuevo Puesto";
                txtbPuesto.Visible = false;
                ddlPuestos.Visible = true;
                btnEliminarPuesto.Text = "Eliminar Puesto";
            }
        }

        //Este metodo sirve para llenar el dropdownlist de puestos, ya sea al inicio o cuando se hace algun cambio
        private void llenarDropListPuestos()
        {

            try {

                //Se obtienen los datos y se almacenan en una tabla
                string jsonPuestos = wsPuestos.ConsultarPuestos();
                DataTable dt = (DataTable)JsonConvert.DeserializeObject(jsonPuestos, typeof(DataTable));

                //Se recorre la tabla y se llena el dropdownlist
                foreach (DataRow row in dt.Rows) {
                    string descripcion = Convert.ToString(row["Puesto"]);
                    ddlPuestos.Items.Add(descripcion);
                }

            } catch (Exception ex) {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Error del servidor.\", \"error\");", true);
            }

        }
        #endregion
    }
}