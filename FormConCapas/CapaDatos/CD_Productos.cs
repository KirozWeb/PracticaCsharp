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

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select * from Productos";

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void Insertar(string nombre, string desc, string marca, float precio, int stock)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into Productos values('" + nombre + "','" + desc + "','" + marca + "','" + precio + "','" + stock + "')";        
            comando.ExecuteNonQuery();
        }

        public void Editar(string nombre, string desc, string marca, float precio, int stock, int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update Productos set Nombre = '" + nombre + "',Descripcion ='" + desc + "',Marca='" +
                marca + "',Precio = '" + precio + "', Stock='" + stock + "'where Id='" + id + "'";
            comando.ExecuteNonQuery();
        }

        public void Eliminar (int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "delete from Productos where Id= '" + id + "'";
            comando.ExecuteNonQuery();
        }
    }
}
