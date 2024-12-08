using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ClinicaVeterinariaApp
{
    public partial class Form1 : Form
    {
        private Form formActual = null; // Mantiene referencia al form actualmente visible

        public Form1()
        {
            InitializeComponent();
        }

        // Evento que se ejecuta cuando el formulario se carga
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        // Método de evento vacío (sin uso) que podrías implementar más tarde
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {

            MostrarForm("Clientes");


        }

        private void buttonMascotas_Click(object sender, EventArgs e)
        {
            MostrarForm("Mascotas");

        }



        private void button3_Click(object sender, EventArgs e)
        {
            MostrarForm("Citas");
        }

        private void buttonAñadir_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void añadirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelMostrar_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void MostrarForm(string tipo)
        {
            Form formSiguiente = null;

            if (tipo == "Clientes")
            {
                if (formActual == null || formActual.GetType() != typeof(FormClientes))
                {
                    formSiguiente = new FormClientes();
                }
            }
            else if (tipo == "Mascotas")
            {
                if (formActual == null || formActual.GetType() != typeof(FormMascotas))
                {
                    formSiguiente = new FormMascotas();
                }
            }
            else if (tipo == "Citas")
            {
                if (formActual == null || formActual.GetType() != typeof(FormCitas))
                {
                    formSiguiente = new FormCitas();
                }
            }

            if (formSiguiente != null)
            {
                ConfigurarForm(formSiguiente);
                formActual = formSiguiente;
            }
        }
       
        private void ConfigurarForm(Form form)
        {
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false; // No se muestra como una ventana separada
            form.Dock = DockStyle.Fill;
            panelMostrar.Controls.Clear(); // Limpia el panel
            panelMostrar.Controls.Add(form); // Agrega el form al panel
            form.Show(); // Muestra el form dentro del panel
        }


    }
}

