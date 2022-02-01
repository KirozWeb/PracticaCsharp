using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenarMayor
{
    public enum Meses
    {
        Enero,Febrero,Marzo,Abril,Mayo,Junio,Julio,Agosto,Septiembre,Octubre,Noviembre,Diciembre
    };

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
            Console.WriteLine("El mes actual es " + Meses.Febrero);
            

            int a, b, c;
            a = b = c = 1;
            a += b += c += 5;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(a + b + c);
            Console.ReadKey();

            string usuario;
            string password;

            Console.WriteLine("Por favor ingrese su usuario : ");
            usuario = Console.ReadLine();
            Console.WriteLine("Por favor ingrese su password : ");
            password = Console.ReadLine();

            if(usuario == "diego" && password == "fercho")
            {
                Console.WriteLine("Felicitaciones ha ingresado al portal");
            }
            else
            {
                Console.WriteLine("Lo siento contrasena o usuario errado");
            }
            Console.ReadKey();

            int opcion;
            int num1 = 3;
            int num2 = 5;
            int total = 0;
            
            
            do
            {
                Console.WriteLine("Seleccione: 1 sumar, 2 restar, 3 multiplicar, 4 salir");
                opcion = Int32.Parse(Console.ReadLine());
                
                    switch (opcion)
                    {
                        case 1:
                            total = num1 + num2;
                            Console.WriteLine("Elegiste sumar {0} + {1} = {2}", num1, num2, total);
                            break;

                        case 2:
                            total = num1 - num2;
                            Console.WriteLine("Elegiste sumar {0} + {1} = {2}", num1, num2, total);
                            break;

                        case 3:
                            total = num1 * num2;
                            Console.WriteLine("Elegiste sumar {0} + {1} = {2}", num1, num2, total);
                            break;

                        default:
                            Console.WriteLine("opcion errada");
                            break;
                    }
                
            } while (opcion != 4);




        }
    }
}
