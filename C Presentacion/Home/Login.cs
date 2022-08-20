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

namespace C_Presentacion.Home
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        MySqlConnection Connection = new MySqlConnection("server = localhost ; user = root ; password = pierinita ; database = dent-av-smile ; INTEGRATED SECURITY = true");
        public String lblusuario;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            try{
                Connection.Open();
                MySqlCommand comando = new MySqlCommand("SELECT Usuario, Contrasena FROM usuarios WHERE Usuario = @vusuario AND Contrasena = @vcontrasena", Connection);
                comando.Parameters.AddWithValue("@vusuario", txtusuario.Text);
                comando.Parameters.AddWithValue("@vcontrasena", txtcontrasena.Text);
                MySqlDataReader lectura = comando.ExecuteReader();
                if (lectura.Read())
                {
                    lblusuario = lectura.GetString(0);
                    MessageBox.Show("Acceso Correcto: "+lblusuario);
                    PantallaPrincipal Principal = new PantallaPrincipal();
                    Principal.usuario = lblusuario;
                    Principal.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña Incorrectos");
                }
                Connection.Close();
            }
            catch (MySqlException error)
            {
                MessageBox.Show("Error de Conexión: \n"+error.GetBaseException());
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
