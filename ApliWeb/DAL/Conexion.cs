using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ApliWeb.DAL
{
    public class Conexion
    {
        private SqlConnection conn;


        public SqlConnection Conn { get => conn; set => conn = value; }

        public SqlConnection connection()
        {
            string constring = ConfigurationManager.ConnectionStrings["mascotaconn"].ToString();
            Conn = new SqlConnection(constring);
            return Conn;
        }
    }
}