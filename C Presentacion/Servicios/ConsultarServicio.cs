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

namespace C_Presentacion.Servicios
{
    public partial class ConsultarServicio : Form
    {
        public ConsultarServicio()
        {
            InitializeComponent();
        }
        MySqlConnection Connection = new MySqlConnection("server = localhost ; user = root ; password = pierinita ; database = dent-av-smile ; INTEGRATED SECURITY = true");

        void presentarDatos()
        {
            try
            {
                Connection.Open();
                string consulta = "SELECT id as 'ID', nombre as 'Nombre', tipo as 'Tipo', descripcion as 'Descripción', Costo as 'Costo($)' FROM servicios;";
                MySqlCommand cmd = new MySqlCommand(consulta, Connection);
                MySqlDataAdapter adp = new MySqlDataAdapter();
                DataTable dt = new DataTable();
                adp.SelectCommand = cmd;
                adp.Fill(dt);
                Connection.Close();
                dataGridView1.DataSource = dt;

            }
            catch (MySqlException error)
            {
                MessageBox.Show("Error de BD: " + error.GetBaseException());
            }
            catch (InvalidOperationException error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }

        private void BtnConsul_Click(object sender, EventArgs e)
        {
            presentarDatos();
        }

        private void ConsultarServicio_Load_1(object sender, EventArgs e)
        {
            presentarDatos();
        }
    }
}
