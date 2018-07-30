using BibliotecaSI.Models;
using Newtonsoft.Json;
using PuntoVentaCliente.WSEmpleados;
using PuntoVentaServidor.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PuntoVentaCliente.Vistas
{
    public partial class Config : System.Web.UI.Page
    {
        Usuarios user;
        WSEmpleadosSoapClient empleados;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                user = new Usuarios();
                empleados = new WSEmpleadosSoapClient();

                user = JsonConvert.DeserializeObject<Usuarios>(empleados.UsuarioDatos(Convert.ToString(Session["User"])));
                

            } catch (Exception) {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"El servidor esta en mantenimiento, regrese mas tarde.\", \"error\");", true);
            }
        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            
            if (txtbUserName.Text != "" && txtbPassword.Text != "" && txtbNewPassword.Text != "" && txtbNewPasswordRepeat.Text != "")
            {

                if (txtbNewPassword.Text == txtbNewPasswordRepeat.Text)
                {

                    string password = Encryption.encrypt(txtbPassword.Text);

                    if (password == user.Password)
                    {

                        password = Encryption.encrypt(txtbNewPassword.Text);

                        user.Usuario = txtbUserName.Text;
                        user.Password = password;

                        string json = JsonConvert.SerializeObject(user);

                        if (empleados.UsuarioActualizar(json))
                            ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Successful\", \"Operacion realizada con exito.\", \"success\");", true);
                        else
                            ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"El servidor esta en mantenimiento, regrese mas tarde.\", \"error\");", true);

                    }
                    else
                        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Aviso\", \"Contraseña anterior incorrecta.\", \"warning\");", true);

                }
                else
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Aviso\", \"La nueva contraseña no coincide en ambos campos.\", \"warning\");", true);

            }
            else
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Aviso\", \"Llene todos los campos.\", \"warning\");", true);
            
        }
    }
}