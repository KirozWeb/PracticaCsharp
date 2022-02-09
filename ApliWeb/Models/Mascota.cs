using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApliWeb.Models
{
    public class Mascota
    {
        private string id_Mascota;
        private string nombre;
        private string edad;
        private string descrip;
        private string correoContacto;
        private bool adoptada;

        public string Id_Mascota { get => id_Mascota; set => id_Mascota = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Edad { get => edad; set => edad = value; }
        public string Descrip { get => descrip; set => descrip = value; }
        public string CorreoContacto { get => correoContacto; set => correoContacto = value; }
        public bool Adoptada { get => adoptada; set => adoptada = value; }
        
    }
}