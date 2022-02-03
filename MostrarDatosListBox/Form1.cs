using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MostrarDatosListBox
{
    public partial class Form1 : Form
    {
        List<string> listaTexto = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string texto;

            texto = txtIngresar.Text;
            txtOtro.Text = texto;
            listaTexto.Add(texto);
            Console.WriteLine("Esto es texto : ",texto);
            lstBoxTexto.DataSource = null;
            lstBoxTexto.DataSource = listaTexto;
        }
    }
}
