using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        CN_Productos objetoCN = new CN_Productos();
        private string idProducto = null;
        private bool Editar = false;
        private bool FormCompleto = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }
        private void MostrarProductos()
        {
            CN_Productos objeto = new CN_Productos();
            dataGridView1.DataSource = objeto.MostrarProd();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //INSERTAR
            revisarform();
            if(FormCompleto == false)
            {
                MessageBox.Show("complete los campos por favor");
            }
            if(FormCompleto == true)
            {
                MessageBox.Show("Campos ok");
                if (Editar == false)
                {
                    try
                    {
                        objetoCN.InsertarProd(txtNombre.Text, txtDesc.Text, txtMarca.Text, txtPrecio.Text, txtStock.Text);
                        MessageBox.Show("Se inserto correctamente");
                        MostrarProductos();
                        limpiarform();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo insertar los datos por: " + ex);
                    }
                }
                //EDITAR
                if (Editar == true)
                {
                    try
                    {
                        MessageBox.Show(" precio " + txtPrecio + " id "+ idProducto);
                        objetoCN.EditarProd(txtNombre.Text, txtDesc.Text, txtMarca.Text, txtPrecio.Text, txtStock.Text, idProducto);
                        MessageBox.Show("Se edito correctamente");
                        MostrarProductos();
                        limpiarform();
                        Editar = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo editar los datos por: " + ex);
                    }
                }
            }
                            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtMarca.Text = dataGridView1.CurrentRow.Cells["Marca"].Value.ToString();
                txtDesc.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtPrecio.Text = dataGridView1.CurrentRow.Cells["Precio"].Value.ToString();
                txtStock.Text = dataGridView1.CurrentRow.Cells["Stock"].Value.ToString();
                idProducto = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
            }
            else
            {
                MessageBox.Show("seleccione una fila por favor");
            }
        }

        private void limpiarform()
        {
            txtNombre.Clear();
            txtDesc.Clear();
            txtMarca.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
        }

        private void revisarform()
        {
            if ((string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtDesc.Text)) || (string.IsNullOrEmpty(txtMarca.Text) || string.IsNullOrEmpty(txtPrecio.Text)) || string.IsNullOrEmpty(txtStock.Text))
            {
                FormCompleto = false;
            }
            else
            {
                FormCompleto = true;
            }
        }
        
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idProducto = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
                objetoCN.EliminarProd(idProducto);
                MessageBox.Show("Eliminado correctamente");
                MostrarProductos();
            }
            else
            {
                MessageBox.Show("seleccione una fila por favor");
            }
        }
    }
}
