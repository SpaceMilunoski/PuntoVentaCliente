using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuntoVentaCliente.Modelos
{
    public class LoginUsuario
    {
        private int acceso;
        private string privilegios;
        private string usuario;

        public LoginUsuario() { }
        
        public int Acceso
        {
            get => acceso;
            set => acceso = value;
        }
        
        public string Privilegios
        {
            get => privilegios;
            set => privilegios = value;
        }
        
        public string Usuario
        {
            get => usuario;
            set => usuario = value;
        }
    }
}