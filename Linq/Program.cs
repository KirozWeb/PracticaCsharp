using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.FUENTE DE DATOS
            int[] datos = new int[] { 2, 4, 7, 8, 15, 20, 12 };

            //2.CREAR CONSULTA
            var consulta = from d in datos select d;

            //3.EJECUTAR CONSULTA
            foreach(var c in consulta)
            {
                Console.WriteLine("Los elementos son: {0}", c);
            }
            Console.ReadKey();
        }
    }
}
