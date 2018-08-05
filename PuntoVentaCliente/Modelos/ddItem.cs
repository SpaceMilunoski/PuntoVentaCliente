using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuntoVentaCliente.Modelos
{
    public class ddItem
    {
        private int id;
        private string nombre;
        public ddItem() { }
        public int Id {
            get => id;
            set => id = value;
        }
        public string Nombre {
            get => nombre;
            set => nombre = value;
        }
    }
}