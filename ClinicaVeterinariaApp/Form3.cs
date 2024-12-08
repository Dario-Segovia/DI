using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ClinicaVeterinariaApp
{
    public partial class FormClientes : Form
    {
        private string connectionString = "Server=localhost;Database=clinicaveterinaria;User=root;Password=dario010904;";

        public FormClientes()
        {
            InitializeComponent();
            CargarDatosClientes();
        }



        private void dataGridClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Aquí puedes manejar cualquier evento de clic en las celdas del DataGridView.
        }

        private void FormClientes_Load(object sender, System.EventArgs e)
        {
            // Evento de carga de formulario.
        }




        private void modificarToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }

        private void eliminarToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

            if (dataGridClientes.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridClientes.SelectedRows[0];
                if (selectedRow.Cells["ClienteID"].Value != null)
                {
                    int clienteId = Convert.ToInt32(selectedRow.Cells["ClienteID"].Value);

                    // Mostrar confirmación antes de eliminar
                    DialogResult dialogResult = MessageBox.Show(
                        "¿Estás seguro de que quieres eliminar este cliente?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (dialogResult == DialogResult.Yes)
                    {
                        EliminarCliente(clienteId);
                    }
                }
                else
                {
                    MessageBox.Show("No se seleccionó ningún cliente.");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente para eliminar.");
            }
        }
        private void EliminarCliente(int clienteId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM clientes WHERE ID = @ClienteID";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ClienteID", clienteId);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cliente eliminado correctamente.");
                            CargarDatosClientes();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el cliente.");
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void CargarDatosClientes()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                SELECT ID as ClienteID, DNI, Nombre, Apellidos, Direccion, Telefono, CP, Localidad, Provincia, Correo, Observaciones
                FROM clientes";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridClientes.DataSource = dt;
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void añadirToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            using (AñadirCliente formAgregar = new AñadirCliente())
            {
                if (formAgregar.ShowDialog() == DialogResult.OK)
                {
                    // Al cerrar el formulario de AñadirCliente, se vuelve a cargar los datos
                    CargarDatosClientes();
                }
            }
        }

        private void textBoxBuscarCliente_TextChanged(object sender, EventArgs e)
        {

            string term = textBoxBuscarCliente.Text.Trim();
            if (!string.IsNullOrEmpty(term))
            {
                FiltrarPorTerm(term);
            }
            else
            {
                CargarDatosClientes(); // Muestra todos los registros si el campo de búsqueda está vacío
            }

        }
        private void FiltrarPorTerm(string term)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                SELECT ID as ClienteID, DNI, Nombre, Apellidos, Direccion, Telefono, CP, Localidad, Provincia, Correo, Observaciones
                FROM clientes
                WHERE DNI LIKE @Term OR Nombre LIKE @Term OR Apellidos LIKE @Term OR Direccion LIKE @Term 
                   OR Telefono LIKE @Term OR CP LIKE @Term OR Localidad LIKE @Term OR Provincia LIKE @Term 
                   OR Correo LIKE @Term OR Observaciones LIKE @Term";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Term", "%" + term + "%");
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridClientes.DataSource = dt;
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void Resetear_Click(object sender, EventArgs e)
        {
            textBoxBuscarCliente.Text = string.Empty;
            CargarDatosClientes(); // Restablece el DataGrid a su estado original con todos los registros
        }
    }
}