using Newtonsoft.Json;
using PuntoVentaCliente.WSEmpleados;
using PuntoVentaCliente.Modelos;
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
        //Webservice y metodo a utilizar
        Usuarios user;
        WSEmpleadosSoapClient empleados;

        protected void Page_Load(object sender, EventArgs e)
        {
            try {
                //Se inicializan los objetos
                user = new Usuarios();
                empleados = new WSEmpleadosSoapClient();

                //Se obtiene los datos del usuario
                user = JsonConvert.DeserializeObject<Usuarios>(empleados.UsuarioDatos(Convert.ToString(Session["User"])));
                
                //Se preparan los textbox
                if (!IsPostBack) {
                    txtbUserName.Text = user.Usuario;
                    txtbPassword.Text = string.Empty;
                }

            } catch (Exception) {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"El servidor esta en mantenimiento, regrese mas tarde.\", \"error\");", true);
            }
        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            //Se verifica que todos los campos esten llenos
            if (txtbUserName.Text != "" && txtbPassword.Text != "" && txtbNewPassword.Text != "" && txtbNewPasswordRepeat.Text != "") {

                //Se verifica que la nueva contraseña se haya puesto bien
                if (txtbNewPassword.Text == txtbNewPasswordRepeat.Text) {

                    //Se encripta la anterior contraseña
                    string password = Encryption.encrypt(txtbPassword.Text);

                    //Se verifica que la anterir coincida con la de la base de datos
                    if (password == user.Password) {

                        //Se encripta la nueva contraseña
                        password = Encryption.encrypt(txtbNewPassword.Text);

                        //Los valores son asignados al modelo
                        user.Usuario = txtbUserName.Text;
                        user.Password = password;

                        //El objeto se serializa en JSON
                        string json = JsonConvert.SerializeObject(user);

                        //Se manda el JSON como parametro del webmethod de actualizar datos
                        if (empleados.UsuarioActualizar(json)) {

                            ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Successful\", \"Operacion realizada con exito.\", \"success\");", true);
                            
                            //Si todo salio bien se actualiza el usuario en la sesion
                            Session["User"] = user.Usuario;

                        }
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