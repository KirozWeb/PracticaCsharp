using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiAgencia
{

    public enum ColorVehiculo
    {
        Ninguno,
        Blanco,
        Gris,
        Rojo,
        Vino,
        Azul
    }
    public enum Estatus
    {
        Existencia,
        Vendido,
        Entregado
    }
    class Vehiculo
    {
        int id;
        int llantas;
        string modelo;
        int anio;
        ColorVehiculo color;
        Estatus estatus;

        public string Capturar()
        {
            return "capturado";
        }

        public string vender()
        {
            return "vendido";
        }

        public Vehiculo()
        {
            id = 0;
            modelo = "";
            anio = 2017;
            llantas = 4;
            color = ColorVehiculo.Ninguno;
            estatus = Estatus.Existencia;
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public int Llantas { get; set; }
        public int Color { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }
    }
}
