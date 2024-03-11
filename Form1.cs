using fundamentos_CSHARP.Models;
using MySql.Data.MySqlClient;
using System.Data;

namespace fundamentosCsharp_2
{
    public partial class Form_data : Form
    {
        ManageDB model = new ManageDB();
        public Form_data()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            view_data();
        }

        private void view_data()
        {
            try
            {
                dataGridView_data.DataSource = null;
                dataGridView_data.AutoGenerateColumns = true;
                DataTable data = model.View();
                dataGridView_data.DataSource = data;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar los datos: " + ex.Message);
                // Mostrar un mensaje de error en una ventana emergente.
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_search_info_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text == "")
            {
                MessageBox.Show("Ingrese el ID del registro a modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                view_data();
                return;
            }
            try
            {
                byte id = Convert.ToByte(textBox_id.Text);

                dataGridView_data.DataSource = null;
                dataGridView_data.AutoGenerateColumns = true;
                DataTable data = model.View(id);
                dataGridView_data.DataSource = data;
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error en una ventana emergente.
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                view_data();
            }
            finally
            {
                textBox_id.Text = "";
            }
        }

        private void button_delete_info_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text == "")
            {
                MessageBox.Show("Ingrese el ID del registro a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                byte id = Convert.ToByte(textBox_id.Text);
                model.Delete(id);
                view_data();
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error en una ventana emergente.
                MessageBox.Show("Error al elimnar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                textBox_id.Text = "";
            }
        }

        private void button_add_info_Click(object sender, EventArgs e)
        {
            if (textBox_Familia.Text == "" || textBox_Sonido.Text == "" || textBox_Tamaño.Text == "" || textBox_Nombre.Text == "" || textBox_Velocidad.Text == "")
            {
                MessageBox.Show("Ingrese toda la información del registro a añadir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                model.Add(
                    Convert.ToByte(textBox_Familia.Text),
                    textBox_Sonido.Text,
                    Convert.ToByte(textBox_Tamaño.Text),
                    textBox_Nombre.Text,
                    Convert.ToByte(textBox_Velocidad.Text));

                view_data();
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error en una ventana emergente.
                MessageBox.Show("Error al Agregar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                textBox_Familia.Text = "";
                ; textBox_Sonido.Text = "";
                textBox_Tamaño.Text = "";
                textBox_Nombre.Text = "";
                textBox_Velocidad.Text = "";
            }
        }

        private void dataGridView_data_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
