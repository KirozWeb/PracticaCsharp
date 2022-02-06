using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ApliWeb.DAL
{
    public class Mascota
    {
        private SqlConnection con;
        private void connection()
        {
            string constring = ConfigurationManager.ConnectionStrings["mascotaconn"].ToString();
            con = new SqlConnection(constring);
        }

        public bool AgregarMascota(Models.Mascota mascota)
        {
            connection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Nombre", mascota.Nombre);
            cmd.Parameters.AddWithValue("@Edad", mascota.Edad);
            cmd.Parameters.AddWithValue("@Descrip", mascota.Descrip);
            cmd.Parameters.AddWithValue("@Correo", mascota.CorreoContacto);
            cmd.Parameters.AddWithValue("@Adoptado", 0);
            cmd.CommandText = "AgregarMascota";
            cmd.Connection = con;
            con.Open();
            int i = cmd.ExecuteNonQuery();
            //Console.WriteLine("Esto es la i en agregarmascota " + i);
            con.Close();
            if (i >= 1)
                return true;
            else
                return false;
        }

        public List<Models.Mascota> ObtenerMascotas()
        {
            connection();
            List<Models.Mascota> mascotas = new List<Models.Mascota>();

            SqlCommand cmd = new SqlCommand("ObtenerMascota", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            con.Open();
            sda.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                mascotas.Add(
                    new Models.Mascota
                    {

                        Nombre = Convert.ToString(dr["nombre"]),
                        Edad = Convert.ToString(dr["edad"]),
                        Descrip = Convert.ToString(dr["descrip"]),
                        CorreoContacto = Convert.ToString(dr["correo"]),
                        Adoptada = Convert.ToBoolean(dr["adoptado"])
                    });
            }
            return mascotas;
        }

    }
}