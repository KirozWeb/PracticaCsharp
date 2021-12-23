using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionRemota
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RecuperarDatos(string url)
        {
            WebClient webClient = new WebClient();
            Stream stream = webClient.OpenRead(url);

            StreamReader reader = new StreamReader(stream);
            string rpta = reader.ReadToEnd();
            reader.Close();

            richTextBox.Text = rpta;
            MessageBox.Show("hola como te va");

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            RecuperarDatos(txtUrl.Text);
        }
    }
}
