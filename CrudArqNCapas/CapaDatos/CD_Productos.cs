using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Productos
    {
        private CD_Conexion conexion = new CD_Conexion();
        
        SqlDataReader leer;  //leer filas de la tabla productos
        DataTable tabla = new DataTable(); //para almacenar las filas de la consulta de SqlDataReader
        SqlCommand comando = new SqlCommand();//Ejecutar sentencias transact sql o procedimientos almacenados

        public DataTable Mostrar()
        {
            //TRANSACT SQL  
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select * from Productos";
            //PROCEDIMIENTO ALMACENADO
            //comando.CommandText = "MostrarProductos";
            //comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public void Insertar(string nombre, string desc, string marca, double precio, int stock)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into Productos values('" + nombre + "','" + desc + "','" + marca + "','" + precio + "','" + stock + "')";
            //comando.CommandType = CommandType.Text;
            //comando.CommandText = "InsertarProductos";
            //comando.CommandType = CommandType.StoredProcedure;
            //comando.Parameters.AddWithValue("@nombre", nombre);
            //comando.Parameters.AddWithValue("@desc", desc);
            //comando.Parameters.AddWithValue("@marca", marca);
            //comando.Parameters.AddWithValue("@precio", precio);
            //comando.Parameters.AddWithValue("@stock", stock);
            comando.ExecuteNonQuery();
            //comando.Parameters.Clear();
        }
        public void Editar(string nombre, string desc, string marca, string precio, int stock, int id)
        {
            comando.Connection = conexion.AbrirConexion();
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";
            Console.WriteLine("esto es precio " + precio);
            var precio2 = precio.Replace(',', '.');
            Console.WriteLine("esta es precio2 en cdproductos: " + precio2);
            var precio3 = float.Parse(precio2, CultureInfo.InvariantCulture);
            Console.WriteLine("esta es precio3 en cdproductos valorconvertido: " + precio3);
            comando.CommandText = "update Productos set Nombre = '" + nombre + "',Descripcion  ='" + desc + "',Marca = '" + marca + "', Precio = '" + precio3 + "', Stock = '" + stock + "' where Id = '" + id + "'";
            // Console.WriteLine("sentencia sql : " + comando.CommandText);
            comando.ExecuteNonQuery();
            comando.CommandText = "";
        }

        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "delete from Productos where Id = '" + id + "'";
            comando.ExecuteNonQuery();

        }

    }
}
