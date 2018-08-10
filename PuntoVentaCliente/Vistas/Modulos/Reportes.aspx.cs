using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuntoVentaCliente.WSVentas;
using System.Data;
using Newtonsoft.Json;

namespace PuntoVentaCliente.Vistas.Modulos
{
    public partial class Reportes : System.Web.UI.Page
    {
        private WSVentasSoapClient wsVentas;
        private Modelos.Ventas reportes;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                wsVentas = new WSVentasSoapClient();
                DataTable dt = (DataTable)JsonConvert.DeserializeObject(wsVentas.ConsultarVentas(), typeof(DataTable));
                GridView_Reportes.DataSource = dt;
                if (!IsPostBack)
                    GridView_Reportes.DataBind();
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Error del servidor.\", \"error\");", true);
            }
        }
        protected void GridView_Reportes_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void GridView_Reportes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        protected void btnPDF_Click(object sender, EventArgs e)
        {

        }
    }
}