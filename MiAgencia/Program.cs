using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Mi Agencia";
            Console.WriteLine("Selecciona opcion de captura: ");
            Console.WriteLine("1 Moto");
            Console.WriteLine("2 Auto");
            Console.WriteLine("3 Camioneta");

            int menu = int.Parse(Console.ReadLine());
            int anio, llantas, color;
            string modelo;
            switch (menu)
            {
                case 1:
                    break;
                case 2:
                    Console.WriteLine("Modelo");
                    modelo = Console.ReadLine();
                    Console.WriteLine("Año");
                    anio = int.Parse(Console.ReadLine());
                    Console.WriteLine("llantas");
                    llantas = int.Parse(Console.ReadLine());
                    Console.WriteLine("Color: 1 Blanco, 2 Gris, 3 Rojo..");
                    color = int.Parse(Console.ReadLine());
                    Automovil miAuto = new Automovil();
                    miAuto.Id = 0;
                    miAuto.Llantas = llantas;
                    miAuto.Modelo = modelo;
                    miAuto.Anio = anio;

                    string resp = miAuto.Capturar();
                    Console.WriteLine("Respuesta: " + resp);
                    Console.ReadKey();
                    break;
            }
        }
    }
}
