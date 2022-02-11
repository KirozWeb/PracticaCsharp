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

        public Mascota()
        {

        }

        public Mascota(string id_Mascota, string nombre, string edad, string descrip, string correoContacto, bool adoptada)
        {
            this.id_Mascota = id_Mascota;
            this.nombre = nombre;
            this.edad = edad;
            this.descrip = descrip;
            this.correoContacto = correoContacto;
            this.adoptada = adoptada;
        }

        public string Id_Mascota { get => id_Mascota; set => id_Mascota = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Edad { get => edad; set => edad = value; }
        public string Descrip { get => descrip; set => descrip = value; }
        public string CorreoContacto { get => correoContacto; set => correoContacto = value; }
        public bool Adoptada { get => adoptada; set => adoptada = value; }
        
    }
}