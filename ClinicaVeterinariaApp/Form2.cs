using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClinicaVeterinariaApp
{
    public partial class AñadirCliente : Form
    {
        private string connectionString = "Server=localhost;Database=clinicaveterinaria;User=root;Password=dario010904;";

        public AñadirCliente()
        {
            InitializeComponent();
        }

        private void AñadirCliente_Load(object sender, EventArgs e)
        {
            // Cargar las provincias al ComboBox
           
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {

            try
            {
                // Captura los datos del formulario
                string nombre = textNombre.Text?.Trim();
                string apellidos = textApellidos.Text?.Trim();
                string direccion = textDireccion.Text?.Trim();
                string telefono = textTelefono.Text?.Trim();
                string correo = textBoxCorreo.Text?.Trim();
                string provincia = textBoxProvincia.Text?.Trim();
                string localidad = textBoxLocalidad.Text?.Trim();
                string cp = textCP.Text?.Trim();
                string dni = textboxDNI.Text?.Trim();

               

                // Guarda el nuevo cliente en la base de datos
                GuardarCliente(nombre, apellidos, direccion, telefono, correo, provincia, localidad, cp, dni);

                // Cerrar el formulario o limpiar los campos
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el cliente: " + ex.Message);
            }
        }
        private void GuardarCliente(string nombre, string apellidos, string direccion, string telefono, string correo, string provincia, string localidad, string cp, string dni)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                INSERT INTO clientes (Nombre, Apellidos, Direccion, Telefono, Correo, Provincia, Localidad, CP, DNI)
                VALUES (@Nombre, @Apellidos, @Direccion, @Telefono, @Correo, @Provincia, @Localidad, @CP, @DNI)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Apellidos", apellidos);
                        cmd.Parameters.AddWithValue("@Direccion", direccion);
                        cmd.Parameters.AddWithValue("@Telefono", telefono);
                        cmd.Parameters.AddWithValue("@Correo", correo);
                        cmd.Parameters.AddWithValue("@Provincia", provincia);
                        cmd.Parameters.AddWithValue("@Localidad", localidad);
                        cmd.Parameters.AddWithValue("@CP", cp);
                        cmd.Parameters.AddWithValue("@DNI", dni);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

            private void buttonCancelar_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {

        }

        private void textCP_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void textApellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void DNI_Click(object sender, EventArgs e)
        {

        }

        private void textBoxLocalidad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
