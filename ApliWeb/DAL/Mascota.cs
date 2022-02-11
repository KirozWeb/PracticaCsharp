using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ApliWeb.DAL
{
    public class Mascota : Models.Mascota
    {

        private Conexion cone = new Conexion();
        //private SqlConnection con;
        //private void connection()
        //{
        //    string constring = ConfigurationManager.ConnectionStrings["mascotaconn"].ToString();
        //    con = new SqlConnection(constring);
        //}

        public bool AgregarMascota(Models.Mascota mascota)
        {
            //connection();
            cone.connection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Nombre", mascota.Nombre);
            cmd.Parameters.AddWithValue("@Edad", mascota.Edad);
            cmd.Parameters.AddWithValue("@Descrip", mascota.Descrip);
            cmd.Parameters.AddWithValue("@Correo", mascota.CorreoContacto);
            cmd.Parameters.AddWithValue("@Adoptado", 0);
            cmd.CommandText = "AgregarMascota";
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

        public List<Models.Mascota> ObtenerMascotas()
        {
            //connection();
            cone.connection();
            List<Models.Mascota> mascotas = new List<Models.Mascota>();

            //SqlCommand cmd = new SqlCommand("ObtenerMascota", con);
            SqlCommand cmd = new SqlCommand("ObtenerMascota", cone.Conn);
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
                mascotas.Add(
                    new Models.Mascota
                    {                        
                        Id_Mascota = Convert.ToString(dr["id_mascota"]),
                        Nombre = Convert.ToString(dr["nombre"]),
                        Edad = Convert.ToString(dr["edad"]),
                        Descrip = Convert.ToString(dr["descrip"]),
                        CorreoContacto = Convert.ToString(dr["correo"]),
                        Adoptada = Convert.ToBoolean(dr["adoptado"])
                    });
            }
            return mascotas;
        }


        public bool AdoptoMascota(int id)
        {
            cone.connection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id_Mascota", id);
            cmd.Parameters.AddWithValue("@Adoptado", 1);
            cmd.CommandText = "AdoptoMascota";
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

        public Models.Mascota BuscarMascota(int id)
        {
            cone.connection();
            Models.Mascota mascota = new Models.Mascota();

            SqlCommand cmd = new SqlCommand("ObtenerUnaMascota", cone.Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Mascota", id);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            //con.Open();
            cone.Conn.Open();
            sda.Fill(dt);
            //con.Close();
            cone.Conn.Close();

            foreach (DataRow dr in dt.Rows)
             {
                 //mascota.Id_Mascota = Convert.ToString(dr["id_mascota"]);
                 //mascota.Nombre = Convert.ToString(dr["nombre"]);
                 //mascota.Edad = Convert.ToString(dr["edad"]);
                 //mascota.Descrip = Convert.ToString(dr["descrip"]);
                 //mascota.CorreoContacto = Convert.ToString(dr["correo"]);
                 //mascota.Adoptada = Convert.ToBoolean(dr["adoptado"]);
                 mascota = new Models.Mascota(Convert.ToString(dr["id_mascota"]), Convert.ToString(dr["nombre"]), Convert.ToString(dr["edad"]), Convert.ToString(dr["descrip"]), Convert.ToString(dr["correo"]), Convert.ToBoolean(dr["adoptado"]));
                Console.WriteLine("Esto es nombre de :" + mascota.Nombre);

             }            
            
            return mascota;
        }

        public bool EditarMascota(Models.Mascota mascota)
        {
            cone.connection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id_Mascota", mascota.Id_Mascota);
            cmd.Parameters.AddWithValue("@Nombre", mascota.Nombre);
            cmd.Parameters.AddWithValue("@Edad", mascota.Edad);
            cmd.Parameters.AddWithValue("@Descrip", mascota.Descrip);
            cmd.Parameters.AddWithValue("@Correo", mascota.CorreoContacto);
            cmd.Parameters.AddWithValue("@Adoptado", 0);
            cmd.CommandText = "EditarMascota";
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

    }
}