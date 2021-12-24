using System;
using CrudconForm.Dato;
using CrudconForm.Modelo;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudconForm
{
    public partial class Form1 : Form
    {
        private DataTable tabla;
        VehiculoAdmin admin = new VehiculoAdmin();
        private void Inicializar()
        {
            tabla = new DataTable();
            
            tabla.Columns.Add("txtId");           
            tabla.Columns.Add("txtMarca");
            tabla.Columns.Add("txtPrecio");
            tabla.Columns.Add("txtColor");
            dgVehiculo.DataSource = tabla;

        }
        public Form1()
        {
            InitializeComponent();
            
            Consultar();
        }

        private void Consultar()
        {
            Inicializar();
            List<vehiculo> lista = admin.Consultar();
            foreach(var item in lista)
            {
                DataRow row = tabla.NewRow();
                row["txtId"] = item.Id;
                row["txtMarca"] = item.marca;
                row["txtPrecio"] = item.precio;
                row["txtColor"] = item.color;
                tabla.Rows.Add(row);
            }
        }

        private void Guardar()
        {
            vehiculo modelo = new vehiculo()
            {
                marca = txtMarca.Text,
                precio = int.Parse(txtPrecio.Text),
                color = txtColor.Text
            };

            admin.Guardar(modelo);
        }

        private void Limpiar()
        {
            txtId.Text = "";
            txtMarca.Text = "";
            txtPrecio.Text = "";
            txtColor.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
            Consultar();
            Limpiar();
        }
    }
}
