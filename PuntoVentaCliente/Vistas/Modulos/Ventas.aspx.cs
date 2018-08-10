using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuntoVentaCliente.WSVentas;
using PuntoVentaCliente.WSProductos;
using System.Data;
using Newtonsoft.Json;

namespace PuntoVentaCliente.Vistas.Modulos
{
    public partial class Ventas : System.Web.UI.Page
    {
        private WSVentasSoapClient wSventas;
        private WSProductosSoapClient wsProductos;
        private Modelos.Ventas ventas;
        private Modelos.Productos productos;
        DataTable dt;
        int j;
        protected void Page_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
        }
        protected void GridView_Ventas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                int index = Convert.ToInt32(e.CommandArgument);
                DataTable dt = (DataTable)GridView_Ventas.DataSource;
                dt.Rows[index].Delete();
                GridView_Ventas.DataSource = dt;
                GridView_Ventas.DataBind();
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Error del servidor.\", \"error\");", true);
            }
        }
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                //  dt = (DataTable)GridView_Ventas.DataSource;
                wsProductos = new WSProductosSoapClient();
                DataTable dt = ((DataTable)JsonConvert.DeserializeObject(wsProductos.BuscarProductos(txtbBusqueda.Text), typeof(DataTable)));
                GridView_Ventas.DataSource = dt;
                GridView_Ventas.DataBind();
                /*  int suma=0;
                  for(int i =0;i<=GridView_Ventas.Rows.Count+2;i++)
                  {
                      GridView_Ventas.Rows[i].Cells[12].Text = "1";
                      GridView_Ventas.Rows[i].Cells[13].Text = Convert.ToString(Convert.ToInt32(GridView_Ventas.Rows[i].Cells[12].Text) * Convert.ToInt32(GridView_Ventas.Rows[i].Cells[7].Text));
                      suma += Convert.ToInt32(GridView_Ventas.Rows[i].Cells[7].Text);
                  }              
                  lbSubtotal.Text = Convert.ToString(suma);*/

            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Error del servidor.\", \"error\");", true);
            }
            ocultarCampos();
        }
        protected void btnVenta_Click(object sender, EventArgs e)
        {

        }
        private void ocultarCampos()
        {
            GridView_Ventas.Columns[0].Visible = false;
            GridView_Ventas.Columns[5].Visible = false;
            GridView_Ventas.Columns[7].Visible = false;
            GridView_Ventas.Columns[8].Visible = false;
            GridView_Ventas.Columns[9].Visible = false;
            GridView_Ventas.Columns[10].Visible = false;
        }
    }
}