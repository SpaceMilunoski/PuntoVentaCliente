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
            //Estas 3 isntrucciones sirven para que si el suario quiere regresar a la pagina anterior tenga que volver a cargar la pagina, ya que habia un problema al cerrar sesion
            Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
            Response.Cache.SetAllowResponseInBrowserHistory(false);
            Response.Cache.SetNoStore();

            //Si no se tiene acceso entonces se redirecciona al login
            if (Convert.ToInt16(Session["Access"]) == 0)
                Response.Redirect("/");

            //Se muestra el nombre del usuario
            lbUserName.Text = Convert.ToString(Session["User"]);

            //Se verifica sus privilegios
            if (Convert.ToString(Session["Privileges"]) == "Administrador")
            {
                lbEmpleados.Visible = true;
                lbReportes.Visible = true;
            }

        }

        //Estos 3 redireccionan a las  paginas que no estan disponibles para los usuarios normales
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
            //Los valores de sesion se vuelven nulos
            Session["Access"] = 0;
            Session["User"] = "";
            Session["Privileges"] = "";

            Response.Redirect("/");
        }
    }
}