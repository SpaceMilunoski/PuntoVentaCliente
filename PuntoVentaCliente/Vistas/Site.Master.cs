using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PuntoVentaCliente
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
            Response.Cache.SetAllowResponseInBrowserHistory(false);
            Response.Cache.SetNoStore();

            if (Convert.ToInt16(Session["Access"]) == 0)
                Response.Redirect("/");

            lbUserName.Text = Convert.ToString(Session["User"]);

            if (Convert.ToString(Session["Privileges"]) == "Administrador")
            {
                lbEmpleados.Visible = true;
                lbReportes.Visible = true;
            }

        }

        protected void lbUserName_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Vistas/Config.aspx");
        }

        protected void lbEmpleados_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Vistas/Modulos/Empleados.aspx");
        }

        protected void lbReportes_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Vistas/Modulos/Reportes.aspx");
        }

        protected void lbCerrarSesion_Click(object sender, EventArgs e)
        {
            Session["Access"] = 0;
            Session["User"] = "";
            Session["Privileges"] = "";

            Response.Redirect("/");
        }
    }
}