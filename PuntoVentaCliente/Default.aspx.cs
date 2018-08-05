using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using PuntoVentaCliente.Modelos;
using PuntoVentaCliente.WSEmpleados;
﻿using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using PuntoVentaCliente.Modelos;
using PuntoVentaCliente.WSEmpleados;
using System;
using System.Web.UI;

namespace PuntoVentaCliente
{
    public partial class _Default : Page
    {
        //Webservice y modelo a utilizar
        WSEmpleadosSoapClient wSEmpleados;
        LoginUsuario login;

        protected void Page_Load(object sender, EventArgs e)
        {
            //Si se accede a esta pagina ya iniciada sesion se le redireccionara al menu principal
            if (Convert.ToInt16(Session["Access"]) == 1)
                Response.Redirect("/Vistas/Menu.aspx");
            
            //Se inician los objetos
            wSEmpleados = new WSEmpleadosSoapClient();
            login = new LoginUsuario();
        }

        protected void btnAcceder_Click(object sender, EventArgs e)
        {
            //Se verifica que los dos campos esten llenos
            if (txtbUser.Text != "" && txtbPassword.Text != "") {

                //Se encrypta la contraseña
                string password = Encryption.encrypt(txtbPassword.Text);

                //Se obtiene los datos del webmethod
                login = JsonConvert.DeserializeObject<LoginUsuario>(wSEmpleados.Login(txtbUser.Text, password));
                
                //Se verifica si se dio acceso al sistema 
                if (login.Acceso == 1) {

                    //Se asignan a la sesion los datos relevantes
                    Session["Access"] = login.Acceso;
                    Session["User"] = login.Usuario;
                    Session["Privileges"] = login.Privilegios;

                    Response.Redirect("/Vistas/Menu.aspx");

                }
                else
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Usuario o contraseña incorrecta.\", \"error\");", true);
            }
            else
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Advertencia\", \"Llene los dos campos.\", \"warning\");", true);

        }
    }
}