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
        WSEmpleadosSoapClient wSEmpleados;
        LoginUsuario login;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToInt16(Session["Access"]) == 1)
                Response.Redirect("/Vistas/Menu.aspx");
            
            wSEmpleados = new WSEmpleadosSoapClient();
            login = new LoginUsuario();
        }

        protected void btnAcceder_Click(object sender, EventArgs e)
        {
            if (txtbUser.Text != "" && txtbPassword.Text != "")
            {
                string password = Encryption.encrypt(txtbPassword.Text);

                JsonSerializerSettings serSettings = new JsonSerializerSettings();
                serSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                

                login = JsonConvert.DeserializeObject<LoginUsuario>(wSEmpleados.Login(txtbUser.Text, password));
                
                if (login.Acceso == 1)
                {
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