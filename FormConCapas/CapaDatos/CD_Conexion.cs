using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    class CD_Conexion
    {
        private System.Data.SqlClient.SqlConnection Conexion = new System.Data.SqlClient.SqlConnection("Server=(local);Database=Practica;Integrated Security=true");
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == System.Data.ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if(Conexion.State == System.Data.ConnectionState.Open)            
               Conexion.Close();
            return Conexion;
            
        }
    }
}
