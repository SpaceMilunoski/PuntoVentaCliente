using Newtonsoft.Json;
using PuntoVentaCliente.WSDepartamentos;
using PuntoVentaCliente.WSProductos;
using PuntoVentaCliente.WSProveedores;
using PuntoVentaCliente.WSUnidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PuntoVentaCliente.Vistas.Modulos
{
    public partial class Productos : System.Web.UI.Page
    {
        //Webservice y modelo a utilizar
        private WSProductosSoapClient wsProductos;
        private WSDepartamentosSoapClient wsDepartamentos;
        private WSProveedoresSoapClient wsProveedores;
        private WSUnidadesSoapClient wsUnidades;

        private Modelos.Productos productos;

        protected void Page_Load(object sender, EventArgs e)
        {
            try {
                //Se instancian los objetos a utilizar
                productos = new Modelos.Productos();

                wsProductos = new WSProductosSoapClient();
                wsDepartamentos = new WSDepartamentosSoapClient();
                wsProveedores = new WSProveedoresSoapClient();
                wsUnidades = new WSUnidadesSoapClient();

                //Se carga la tabla
                cargarTabla();

                //Esto sirve para que los valores no queden estaticos al asignarlos
                if (!IsPostBack) {
                    GridView_Productos.DataBind();
                    btnInsertar.Text = "Agregar Producto";

                    ocultarCampos();

                    txtbId.Text = "0";

                    llenarDropListProveedores();
                    llenarDropListDepartamentos();
                    llenarDropListUnidades();
                }

            } catch (Exception ex) {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Error del servidor.\", \"error\");", true);
            }
        }

        #region Editar, Insertar, Eliminar y Buscar

        //Evento el cual recupera los datos de la tabla y los carga en los campos correspondiemtes, ademas este evento sirve para eliminar el producto
        protected void GridView_Productos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try {
                //Se obtiene el indice de la fila la cual se escogio
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView_Productos.Rows[index];
                
                //Se verifica que boton se escogio si editar o eliminar
                if (e.CommandName == "Editar") {

                    //Se cargan los datos de la tabla en los textbox
                    txtbId.Text = Convert.ToString(row.Cells[0].Text);
                    txtbCodigo.Text = row.Cells[1].Text;
                    txtbNombre.Text = row.Cells[2].Text;
                    txtbMarca.Text = row.Cells[3].Text;
                    txtbDescripcion.Text = row.Cells[4].Text;
                    txtbCostoCompra.Text = row.Cells[5].Text;
                    txtbCostoVenta.Text = row.Cells[6].Text;
                    txtbStock.Text = row.Cells[7].Text;

                    ddlProveedor.SelectedValue = row.Cells[8].Text;
                    ddlDepartamentos.SelectedValue = row.Cells[9].Text;
                    ddlUnidad.SelectedValue = row.Cells[10].Text;

                    btnInsertar.Text = "Actualizar Producto";

                } else if (e.CommandName == "Eliminar") {
                    
                    //Se elimina el producto seleccionado y se actualiza la tabla
                    if(wsProductos.EliminarProducto(Convert.ToInt32(row.Cells[0].Text))) {
                        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Successful\", \"Operacion realizada con exito.\", \"success\");", true);
                        actualizacionTabla();
                    } else
                        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Error del servidor.\", \"error\");", true);

                } else if (e.CommandName == "Agregar") {

                    Console.Write("Agregar");

                }

            } catch (Exception ex) {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Error del servidor.\", \"error\");", true);
            }
        }

        //Evento para insertar o actualizar un producto
        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            //Se verifica que se hayan llenado los campos obligatorios
            if (txtbCodigo.Text != "" && txtbNombre.Text != "" && txtbMarca.Text != "" && txtbDescripcion.Text != "" &&
                txtbCostoCompra.Text != "" && txtbCostoVenta.Text != "" && Convert.ToInt32(txtbStock.Text) > 0) {

                
                //Se capturan los datos de los textbox en sus respectivos modelos
                productos.Id = Convert.ToInt16(txtbId.Text);
                productos.Codigo = txtbCodigo.Text;
                productos.Nombre = txtbNombre.Text;
                productos.Marca = txtbMarca.Text;
                productos.Descripcion = txtbDescripcion.Text;
                productos.CostoCompra = Convert.ToDecimal(txtbCostoCompra.Text);
                productos.CostoVenta = Convert.ToDecimal(txtbCostoVenta.Text);

                productos.Stock = Convert.ToInt16(txtbStock.Text);
                productos.Proveedor = ddlProveedor.SelectedValue;
                productos.Departamento = ddlDepartamentos.SelectedValue;
                productos.Unidad = ddlUnidad.SelectedValue;

                //Se serializan los modelos a JSON
                String json = JsonConvert.SerializeObject(productos);

                //Se verifica si se desea insertar o actualizar
                if (btnInsertar.Text == "Agregar Producto") {
                    //Se manda el JSON por el metodo de insertar
                    if (wsProductos.InsertarProducto(json)) {
                        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Successful\", \"Operacion realizada con exito.\", \"success\");", true);
                        actualizacionTabla();
                    } else
                        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Error del servidor.\", \"error\");", true);

                } else if (btnInsertar.Text == "Actualizar Producto") {
                    //Se manda el JSON por el metodo de actualizar
                    if (wsProductos.ActualizarProducto(json)) {
                        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Successful\", \"Operacion realizada con exito.\", \"success\");", true);
                        actualizacionTabla();
                    } else
                        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Error del servidor.\", \"error\");", true);

                    btnInsertar.Text = "Agregar Producto";
                }

                //Se vacian de nuevo los campos
                txtbCodigo.Text = string.Empty;
                txtbNombre.Text = string.Empty;
                txtbMarca.Text = string.Empty;
                txtbDescripcion.Text = string.Empty;
                txtbCostoCompra.Text = string.Empty;
                txtbCostoVenta.Text = string.Empty;
                txtbStock.Text = string.Empty;

                
            }
            else
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Warning\", \"Llene los campos obligatorios (*).\", \"warning\");", true);

        }

        //Evento para buscar un producto ya sea por nombre, marca o codigo
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                mostrarCampos();

                //Se llena la tabla con los datos obtenidos del metodo buscar en el servicio web
                DataTable dt = (DataTable)JsonConvert.DeserializeObject(wsProductos.BuscarProductos(txtbBusqueda.Text), typeof(DataTable));
                GridView_Productos.DataSource = dt;

                //Se llena el datagridview
                GridView_Productos.DataBind();

                ocultarCampos();

                txtbBusqueda.Text = string.Empty;
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Error del servidor.\", \"error\");", true);
            }
        }

        #endregion

        #region Metodos auxiliares para la tabla

        //Se utiliza para no repetir el codigo, ya que se utiliza en algunas partes
        private void cargarTabla()
        {
            DataTable dt = (DataTable)JsonConvert.DeserializeObject(wsProductos.ConsultarProductos(), typeof(DataTable));
            GridView_Productos.DataSource = dt;
        }

        //Esto metodo sirve para que cuando se cargue la tabla se guarden todos los datos, ya que si estan invisibles no se guardan
        private void mostrarCampos()
        {
            GridView_Productos.Columns[0].Visible = true;
        }

        //En este metodo hacemos invisibles los campo una vez cargados los datos (los doatos no se borraran), esto sirve para darle estetica a la tabla
        private void ocultarCampos()
        {
            GridView_Productos.Columns[0].Visible = false;
        }

        //Este metodo actualiza los datos de la tabla
        private void actualizacionTabla()
        {
            mostrarCampos();

            cargarTabla();
            GridView_Productos.DataBind();

            ocultarCampos();
        }

        //Este evento sirve para poder cambiar de paginacion en la tabla
        protected void GridView_Productos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView_Productos.PageIndex = e.NewPageIndex;
            GridView_Productos.DataBind();
        }
        #endregion

        #region Proveedores

        //Este metodo sirve para llenar el dropdownlist de proveedores, ya sea al inicio o cuando se hace algun cambio
        private void llenarDropListProveedores()
        {
            try
            {

                //Se obtienen los datos y se almacenan en una tabla
                string jsonProveedores = wsProveedores.ConsultarProveedores();
                DataTable dt = (DataTable)JsonConvert.DeserializeObject(jsonProveedores, typeof(DataTable));

                //Se recorre la tabla y se llena el dropdownlist
                foreach (DataRow row in dt.Rows)
                {
                    string descripcion = Convert.ToString(row["RazonSocial"]);
                    ddlProveedor.Items.Add(descripcion);
                }

            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Error del servidor.\", \"error\");", true);
            }

        }

        #endregion

        #region Departamentos

        //Eventos para agregar departamento
        protected void btnAgregarDepartamento_Click(object sender, EventArgs e)
        {
            //Condicion ya que el boton tiene dos modalidades, la primera es cambiar el dropdownlist por un textbox y la segunda es agregar el departamento a la base de datos 
            if (btnAgregarDepartamento.Text == "Nuevo Dpto.")
            {

                btnAgregarDepartamento.Text = "Agregar Dpto.";
                txtbDepartamento.Visible = true;
                ddlDepartamentos.Visible = false;
                btnEliminarDepartamento.Text = "Cancelar";

            }
            else
            {

                if (txtbDepartamento.Text != "")
                {

                    if (wsDepartamentos.InsertarDepartamento(txtbDepartamento.Text))
                    {
                        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Successful\", \"Operacion realizada con exito.\", \"success\");", true);

                        ddlDepartamentos.Items.Clear();
                        llenarDropListDepartamentos();

                        btnAgregarDepartamento.Text = "Nuevo Dpto.";
                        txtbDepartamento.Visible = false;
                        ddlDepartamentos.Visible = true;
                        btnEliminarDepartamento.Text = "Eliminar Dpto.";

                        txtbDepartamento.Text = "";
                    }
                    else
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
                if (wsDepartamentos.EliminarDepartamento(ddlDepartamentos.SelectedValue))
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Successful\", \"Operacion realizada con exito.\", \"success\");", true);

                    ddlDepartamentos.Items.Clear();
                    llenarDropListDepartamentos();

                }
                else
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Error del servidor.\", \"error\");", true);

            }
            else if (btnEliminarDepartamento.Text == "Cancelar")
            {

                btnAgregarDepartamento.Text = "Nuevo Dpto.";
                txtbDepartamento.Visible = false;
                ddlDepartamentos.Visible = true;
                btnEliminarDepartamento.Text = "Eliminar Dpto.";
            }
        }

        //Este metodo sirve para llenar el dropdownlist de departamentos, ya sea al inicio o cuando se hace algun cambio
        private void llenarDropListDepartamentos()
        {
            try
            {

                //Se obtienen los datos y se almacenan en una tabla
                string jsonDepartamentos = wsDepartamentos.ConsultarDepartamentos();
                DataTable dt = (DataTable)JsonConvert.DeserializeObject(jsonDepartamentos, typeof(DataTable));

                //Se recorre la tabla y se llena el dropdownlist
                foreach (DataRow row in dt.Rows)
                {
                    string descripcion = Convert.ToString(row["Departamento"]);
                    ddlDepartamentos.Items.Add(descripcion);
                }

            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Error del servidor.\", \"error\");", true);
            }

        }

        #endregion

        #region Unidades

        //Eventos para agregar unidad
        protected void btnAgregarUnidad_Click(object sender, EventArgs e)
        {
            //Condicion ya que el boton tiene dos modalidades, la primera es cambiar el dropdownlist por un textbox y la segunda es agregar la unidad a la base de datos 
            if (btnAgregarUnidad.Text == "Nueva Unidad")
            {

                btnAgregarUnidad.Text = "Agregar Unidad";
                txtbUnidad.Visible = true;
                ddlUnidad.Visible = false;
                btnEliminarUnidad.Text = "Cancelar";

            }
            else
            {

                if (txtbUnidad.Text != "")
                {

                    if (wsUnidades.InsertarUnidad(txtbUnidad.Text))
                    {
                        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Successful\", \"Operacion realizada con exito.\", \"success\");", true);

                        ddlUnidad.Items.Clear();
                        llenarDropListUnidades();

                        btnAgregarUnidad.Text = "Nueva Unidad";
                        txtbUnidad.Visible = false;
                        ddlUnidad.Visible = true;
                        btnEliminarUnidad.Text = "Eliminar Unidad";

                        txtbUnidad.Text = "";
                    }
                    else
                        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Error del servidor.\", \"error\");", true);

                }
            }
        }

        //Evento para eliminar una unidad
        protected void btnEliminarUnidad_Click(object sender, EventArgs e)
        {
            //Condicion ya que el boton tiene dos modalidades, la primera es eliminar la unidad de la base de datos y el segundo cancelar la operacion cuando se quiere agregar una unidad
            if (btnEliminarUnidad.Text == "Eliminar Unidad")
            {
                if (wsUnidades.EliminarUnidad(ddlUnidad.SelectedValue))
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Successful\", \"Operacion realizada con exito.\", \"success\");", true);

                    ddlUnidad.Items.Clear();
                    llenarDropListUnidades();

                }
                else
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Error del servidor.\", \"error\");", true);

            }
            else if (btnEliminarUnidad.Text == "Cancelar")
            {

                btnAgregarUnidad.Text = "Nueva Unidad.";
                txtbUnidad.Visible = false;
                ddlUnidad.Visible = true;
                btnEliminarUnidad.Text = "Eliminar Unidad";
            }
        }

        //Este metodo sirve para llenar el dropdownlist de unidades, ya sea al inicio o cuando se hace algun cambio
        private void llenarDropListUnidades()
        {
            try {

                //Se obtienen los datos y se almacenan en una tabla
                string jsonUnidades = wsUnidades.ConsultarUnidades();
                DataTable dt = (DataTable)JsonConvert.DeserializeObject(jsonUnidades, typeof(DataTable));

                //Se recorre la tabla y se llena el dropdownlist
                foreach (DataRow row in dt.Rows) {
                    string descripcion = Convert.ToString(row["Unidad"]);
                    ddlUnidad.Items.Add(descripcion);
                }

            } catch (Exception ex) {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Error del servidor.\", \"error\");", true);
            }

        }

        #endregion
    }
}