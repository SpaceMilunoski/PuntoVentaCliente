using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PuntoVentaCliente.Vistas.Modulos
{
    public partial class Productos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView_Pr_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

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

                    nombre.Text = row.Cells[1].Text;
                    ddIdmarca.Text = row.Cells[2].Text;
                    ddIdproveedor.Text = row.Cells[3].Text;
                    descripcion.Text = row.Cells[4].Text;
                    costo_venta.Text = row.Cells[5].Text;
                    costo_compra.Text = row.Cells[6].Text;
                    stock.Text = row.Cells[7].Text;
                    fecha_registro.Text = row.Cells[8].Text;
                    ddunidad_medida.Text = row.Cells[9].Text;
                    fecha_caducidad.Text = row.Cells[10].Text;
                    dddepartamento.Text = row.Cells[11].Text;
                    //btnInsertar.Text = "Actualizar";

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
    }
}