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

namespace C_Presentacion.Servicios
{
    public partial class NuevoServicio : Form
    {
        public NuevoServicio()
        {
            InitializeComponent();
        }
        MySqlConnection Connection = new MySqlConnection("server = localhost ; user = root ; password = 8753Jeff.2 ; database = dent-av-smile ; INTEGRATED SECURITY = true");
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void NuevoServicio_Load(object sender, EventArgs e)
        {
            //this.panelT.BackColor = Color.FromArgb(200, 255, 255, 255);
        }

        private void BtnActuServ_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();
                MySqlCommand comando = new MySqlCommand("", Connection);
                //comando.Parameters.AddWithValue("@vusuario", txtusuario.Text);
                MySqlDataReader lectura = comando.ExecuteReader();
                if (lectura.Read())
                {
                    /*MessageBox.Show("Acceso Correcto");
                    antallaPrincipal Principal = new PantallaPrincipal();
                    Principal.Show();*/
                }
                else
                {
                    //MessageBox.Show("Usuario o Contraseña Incorrectos");
                }
                Connection.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("Error de Conexión");
            }
        }
    }
}
