using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuntoVentaCliente.Modelos;
using PuntoVentaCliente.WSProductos;
using PuntoVentaCliente.WSDepartamentos;
using PuntoVentaCliente.WSProveedores;
using PuntoVentaCliente.WSUnidades;
using System.Data;
using Newtonsoft.Json;

namespace PuntoVentaCliente.Vistas.Modulos
{
    public partial class Productos : System.Web.UI.Page
    {
        private int Id;
        private WSProductosSoapClient wsProductos;
        private WSProveedoresSoapClient wsProveedores;
        private WSDepartamentosSoapClient wsDepartamentos;
        private WSUnidadesSoapClient wsUnidades;
        private String fecha;
        private Modelos.Productos productos;
        private List<ddItem> lproveedores = new List<ddItem>();
        private List<ddItem> ldepartamentos = new List<ddItem>();
        private List<ddItem> lunidades = new List<ddItem>();
        //private ;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                wsProductos = new WSProductosSoapClient();
                wsProveedores = new WSProveedoresSoapClient();
                wsDepartamentos = new WSDepartamentosSoapClient();
                wsUnidades = new WSUnidadesSoapClient();
                productos = new Modelos.Productos();
                cargarTabla();
                if (!IsPostBack)
                {
                    GridView_Productos.DataBind();
                    //ocultarCampos();
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
                ddItem item; 
                string jsonProveedores = wsProveedores.ConsultarProveedores();
                dt = (DataTable)JsonConvert.DeserializeObject(jsonProveedores, typeof(DataTable));

                foreach (DataRow row in dt.Rows)
                {
                    item = new ddItem();
                    item.Id = Convert.ToInt32(row["Id"]);
                    item.Nombre = Convert.ToString(row["RazonSocial"]);
                    lproveedores.Add(item);
                    ddproveedor.Items.Add(item.Nombre);
                }

                string jsonDepartamentos = wsDepartamentos.ConsultarDepartamentos();
                dt = (DataTable)JsonConvert.DeserializeObject(jsonDepartamentos, typeof(DataTable));

                foreach (DataRow row in dt.Rows)
                {
                    item = new ddItem();
                    item.Id = Convert.ToInt32(row["Id"]);
                    item.Nombre = Convert.ToString(row["Departamento"]);
                    ldepartamentos.Add(item);
                    dddepartamento.Items.Add(item.Nombre);
                }

                string jsonUnides = wsUnidades.ConsultarUnidades();
                dt = (DataTable)JsonConvert.DeserializeObject(jsonUnides, typeof(DataTable));

                foreach (DataRow row in dt.Rows)
                {
                    item = new ddItem();
                    item.Id = Convert.ToInt32(row["Id"]);
                    item.Nombre = Convert.ToString(row["Unidad"]);
                    lunidades.Add(item);
                    ddunidad_medida.Items.Add(item.Nombre);
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script language=javascript> alert('" + ex.Message + "'); </script>");
            }

        }
        protected void GridView_Pr_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView_Productos.PageIndex = e.NewPageIndex;
            GridView_Productos.DataBind();
        }

        protected void GridView_Productos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {

                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView_Productos.Rows[index];
                identificador.Text = Convert.ToString(row.Cells[0].Text);
                if (e.CommandName == "Editar")
                {
                    Id = Convert.ToInt32(row.Cells[0].Text);
                    identificador.Text = row.Cells[1].Text;
                    nombre.Text = row.Cells[2].Text;
                    marca.Text = row.Cells[3].Text;
                    descripcion.Text = row.Cells[4].Text;
                    costo_venta.Text = row.Cells[5].Text;
                    costo_compra.Text = row.Cells[6].Text;
                    stock.Text = row.Cells[7].Text;
                    ddproveedor.SelectedValue= row.Cells[8].Text;
                    dddepartamento.SelectedValue = row.Cells[9].Text;
                    ddunidad_medida.SelectedValue = row.Cells[10].Text;
                    //btnInsertar.Text = "Actualizar";
                    btnAgregar.Text = Id+"";

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
        private void cargarTabla()
        {
            string json = wsProductos.ConsultarProductos();
            DataTable dt = (DataTable)JsonConvert.DeserializeObject(json, typeof(DataTable));
            GridView_Productos.DataSource = dt;
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            if (nombre.Text != "" && identificador.Text != "" && marca.Text != "" && descripcion.Text != "" && costo_venta.Text != "" && costo_compra.Text != "" && stock.Text != "" )
            {
                
                if (wsProductos.InsertarProducto(datostoJson()))
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Successful\", \"Operacion realizada con exito.\", \"success\");", true);

                    mostrarCampos();

                    cargarTabla();
                    GridView_Productos.DataBind();

                    ocultarCampos();
                    resetearDatos();
                }
                else
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Error del servidor.\", \"error\");", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Warning\", \"Llene todos los campos.\", \"warning\");", true);
            }
        }
        private void mostrarCampos()
        {
            GridView_Productos.Columns[0].Visible = true;
        }

        private void ocultarCampos()
        {
            GridView_Productos.Columns[0].Visible = false;
        }
        private String datostoJson (){
            productos.Id = Id;
            productos.Codigo = identificador.Text;
            productos.Nombre = nombre.Text;
            productos.Marca = marca.Text;
            productos.Descripcion = descripcion.Text;
            productos.CostoVenta = Convert.ToSingle(costo_venta.Text);
            productos.CostoCompra = Convert.ToSingle(costo_compra.Text);
            productos.Stock = Convert.ToInt32(stock.Text);
            productos.Proveedor = ddproveedor.Text;
            productos.Departamento = dddepartamento.Text;
            productos.Unidad = ddunidad_medida.Text;
            String json = JsonConvert.SerializeObject(productos);
            return json;
        }
        private void resetearDatos()
        {
            Id = 0;
            identificador.Text = "";
            nombre.Text = "";
            marca.Text = "";
            descripcion.Text = "";
            costo_compra.Text = "";
            costo_venta.Text = "";
            stock.Text = "";
            dddepartamento.SelectedIndex = 0;
            ddproveedor.SelectedIndex = 0;
            ddunidad_medida.SelectedIndex = 0;
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            if (wsProductos.ActualizarProducto(datostoJson()))
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Successful\", \"Operacion realizada con exito.\", \"success\");", true);

                mostrarCampos();

                cargarTabla();
                GridView_Productos.DataBind();

                ocultarCampos();
                resetearDatos();
            }
            else
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Error del servidor.\", \"error\");", true);

        }
    }
}