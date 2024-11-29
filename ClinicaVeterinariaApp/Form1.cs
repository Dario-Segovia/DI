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
        public Form1()
        {
            InitializeComponent();
        }

        // Evento que se ejecuta cuando el formulario se carga
        private void Form1_Load(object sender, EventArgs e)
        {
            // Cadena de conexión adaptada para la base de datos AgendaContactos
            string connectionString = "Server=localhost; Database=AgendaContactos; Uid=root; Pwd=;";

            // Crear la conexión a la base de datos
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                   

                    // Consulta SQL para obtener todos los contactos
                    string query = "SELECT ID, DNI, Nombre, Apellidos, Direccion, Telefono, CP, Localidad, Provincia, CorreoElectronico, Observaciones FROM Contactos";

                    // Crear el adaptador y el DataTable
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();

                    // Llenar el DataTable con los datos obtenidos
                    da.Fill(dt);

                    // Asignar el DataTable al DataGridView para mostrar los datos
                    dataGridView1.DataSource = dt;

                    // Cambiar el tamaño de las columnas
                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        // Ajustar el ancho de las columnas según su contenido
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                        // O, si prefieres un tamaño fijo:
                        // column.Width = 120;  // Esto asigna un ancho fijo de 120 píxeles
                    }

                    // Cambiar la altura de las filas
                    dataGridView1.RowTemplate.Height = 30;  // Establece una altura fija para las filas

                }
                catch (Exception ex)
                {
                    // Mostrar un mensaje de error en caso de fallo
                    MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
                }
            }
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
    }
}
