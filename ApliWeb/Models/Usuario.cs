using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApliWeb.Models
{
    public class Usuario
    {
        private string id_usuario;
        private string nombre;
        private string apellido;
        private string direccion;
        private string telefono;
        private int id_rol;

        

        public string Id_Usuario { get => id_usuario; set => id_usuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public int Id_rol { get => id_rol; set => id_rol = value; }
    }
}