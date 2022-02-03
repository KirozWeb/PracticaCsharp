using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqcorregido
{
    class Program
    {
        static void Main(string[] args)
        {
            ////1.FUENTE DE DATOS
            //int[] datos = new int[] { 2, 4, 7, 8, 15, 20, 12 };

            ////2.CREAR CONSULTA
            ////var consulta = from d in datos select d;
            //var consulta = from d in datos where (d % 2) == 0 select d;

            ////3.EJECUTAR CONSULTA
            //foreach(var c in consulta)
            //{
            //    Console.WriteLine("Los elementos son: {0}", c);
            //}

            //Se crea un IEnumerable y los datos de Persona se almacenan alli

            Persona[] personas = {new Persona("Jose", "Suarez", 25),
                                  new Persona("Marco", "De la fuente", 34),
                                  new Persona("Pablo", "Escobar", 37)};

            IEnumerable<Persona> consulta = from p in personas where p.Edad > 30 select p;

            Console.WriteLine("Se crea un IEnumerable y los datos de Persona se almacenan alli");
            foreach (Persona per in consulta)
            {
                Console.WriteLine(per.Nombre + " " + per.Apellidos);
            }


            //Se crean un objeto de conexion a la base de datos

            ColegioContextDataContext _db = new ColegioContextDataContext();

            var alumnos = from a in _db.tb_alumno
                          select a;
            /*where a.calificacion > 12
            orderby a.apellidos select a;*/
            Console.WriteLine("Se crean un objeto de conexion a la base de datos, se hace iteracion " +
                              "con un objeto tb_alumno");
            foreach (tb_alumno tb in alumnos)
            {
                Console.WriteLine(tb.nombres + " " + tb.apellidos);
            }


            //Se hace una consulta y se almacena en una variable tipo

            var alumnosos = from a in _db.tb_alumno
                          select a.apellidos;

            Console.WriteLine(alumnos.GetType());
            Console.WriteLine("Se hace una consulta y se almacena en una variable tipo " +
                              "se itera por medio de una variable string");
            foreach (string al in alumnosos)
            {
                Console.WriteLine(al);
            }


            //Se hace consulta y se almacena en un IQueryable
            IQueryable<tb_alumno> consulta2 = from p in _db.tb_alumno
                                             orderby p.nombres                                       
                                             select p;
            Console.WriteLine("Se hace consulta y se almacena en un IQueryable");
            foreach (tb_alumno t in consulta2)
            {
                Console.WriteLine("{0} {1}", t.nombres, t.apellidos);
            }

            IQueryable<tb_alumno> consulta3 = (from p in _db.tb_alumno
                                              select p).OrderByDescending(q => q.nombres);
            Console.WriteLine("Se hace consulta y se almacena en un IQueryable otra vez");
            foreach (tb_alumno t in consulta3)
            {
                Console.WriteLine("{0} {1}", t.nombres, t.apellidos);
            }

            //Con condicionales de manera externa
            Console.WriteLine("Condicional de manera externa");
            string primerApellidos = (from a in _db.tb_alumno select a.apellidos).First();
            Console.WriteLine(primerApellidos);

            IEnumerable<string> apellidos = consulta3.Select(m => m.apellidos);

            Console.WriteLine("Esto es una consulta que se mete en un IEnumerable y sigue");
            foreach (string t in apellidos)
            {
                Console.WriteLine("{0}", t);
            }
            

            var union = from al in _db.tb_alumno
                       join g in _db.tb_grado on al.id equals g.id
                       select new
                       {
                           Nombres = al.nombres,
                           Apellidos = al.apellidos,
                           Grado = g.nombre,
                           Seccion = g.seccion,
                           Capacidad = g.capacidad
                       };

            Console.WriteLine("Esto es un foreach que imprime la union de dos tablas");
            foreach( var r in union)
            {
                Console.WriteLine("{0} {1} - {2} {3} {4}", r.Nombres, r.Apellidos, r.Grado, r.Seccion, r.Capacidad);
            }

            //calcular el promedio con sentencia transac sql

            double promedio = (double)(from al in _db.tb_alumno select al.calificacion).Average();

            Console.WriteLine("el promedio es : " + promedio);


            Console.ReadKey();
        }
    }
}
