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
        MySqlConnection Connection = new MySqlConnection("server = localhost ; user = root ; password = pierinita ; database = dent-av-smile ; INTEGRATED SECURITY = true");
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
                MySqlCommand comando = new MySqlCommand("INSERT INTO servicios (nombre,tipo,descripcion,Costo) VALUES ( @nombre, @tipo, @descripcion,@costo);", Connection);
                comando.Parameters.AddWithValue("@nombre", txtNomServ.Text);
                comando.Parameters.AddWithValue("@tipo", CmbTipoServ.SelectedItem);
                comando.Parameters.AddWithValue("@descripcion", txtDescrServ.Text);
                comando.Parameters.AddWithValue("@costo", txtCostServ.Text);
                MySqlDataReader lectura = comando.ExecuteReader();
                MessageBox.Show("Servicio guardado");
                Connection.Close();
                limpiar();
            }
            catch (MySqlException error)
            {
                MessageBox.Show("Error de BD: "+error.GetBaseException());
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        void limpiar()
        {
            txtNomServ.Text = "";
            CmbTipoServ.SelectedIndex = 0;
            txtDescrServ.Text = "";
            txtCostServ.Text = "";
            txtNomServ.Focus();
        }

    }
}
