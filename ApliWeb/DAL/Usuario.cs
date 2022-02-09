using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace ApliWeb.DAL
{
    public class Usuario
    {
        private Conexion cone = new Conexion();
        //private SqlConnection con;
        //private void connection()
        //{
        //    string constring = ConfigurationManager.ConnectionStrings["mascotaconn"].ToString();
        //    con = new SqlConnection(constring);
        //}

        public bool AgregarUsuario(Models.Usuario usuario)
        {
            //connection();
            cone.connection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre );
            cmd.Parameters.AddWithValue("@Apellido", usuario.Apellido);
            cmd.Parameters.AddWithValue("@Direccion", usuario.Direccion);
            cmd.Parameters.AddWithValue("@Telefono", usuario.Telefono);
            cmd.Parameters.AddWithValue("@Id_rol", usuario.Id_rol);
            cmd.CommandText = "AgregarUsuario";
            //cmd.Connection = con;
            cmd.Connection = cone.Conn;
            //con.Open();
            cone.Conn.Open();
            int i = cmd.ExecuteNonQuery();

            //con.Close();
            cone.Conn.Close();
            if (i >= 1)
                return true;
            else
                return false;
        }

        public List<Models.Usuario> ObtenerUsuario()
        {
            //connection();
            cone.connection();
            List<Models.Usuario> usuario = new List<Models.Usuario>();

            //SqlCommand cmd = new SqlCommand("ObtenerMascota", con);
            SqlCommand cmd = new SqlCommand("ObtenerUsuario", cone.Conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            //con.Open();
            cone.Conn.Open();
            sda.Fill(dt);
            //con.Close();
            cone.Conn.Close();

            foreach (DataRow dr in dt.Rows)
            {
                usuario.Add(
                    new Models.Usuario
                    {
                        Id_Usuario = Convert.ToString(dr["id_usuario"]),
                        Nombre = Convert.ToString(dr["nombre"]),
                        Apellido = Convert.ToString(dr["apellido"]),
                        Direccion = Convert.ToString(dr["direccion"]),
                        Telefono = Convert.ToString(dr["telefono"]),
                        Id_rol = Convert.ToInt32(dr["id_rol"])
                    });
            }
            return usuario;
        }
    }
}