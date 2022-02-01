using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenarMayor
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList numeros = new ArrayList();
            int temporal = 0;
            int mayor = 0;
            int num;
            int dato;

            Console.WriteLine("Ingrese el numero de datos a ingresar");
            num = Int32.Parse(Console.ReadLine());
            for(int i = 0; i < num; i++)
            {
                Console.WriteLine("Ingrese el numero " + (i + 1));
                dato = Int32.Parse(Console.ReadLine());
                numeros.Add(dato);
            }
            for (int i = 0; i < num; i++)
            {
                if (i == 0)
                {
                    mayor = (int)numeros[i];
                }
                else
                {
                    if(mayor < (int)numeros[i])
                    {
                        temporal = (int) numeros[0];
                        numeros[0] = numeros[i];
                        mayor = (int)numeros[i];
                        numeros[i] = temporal;
                    }
                }
            }

            Console.WriteLine("Este es el mayor " + numeros[0]);
            Console.ReadKey();

        }
    }
}
