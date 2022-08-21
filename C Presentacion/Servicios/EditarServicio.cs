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
    public partial class EditarServicio : Form
    {
        public EditarServicio()
        {
            InitializeComponent();
        }
        MySqlConnection Connection = new MySqlConnection("server = localhost ; user = root ; password = pierinita ; database = dent-av-smile ; INTEGRATED SECURITY = true");
        private void EditarServicio_Load(object sender, EventArgs e)
        {
            //this.panelEditServ.BackColor = Color.FromArgb(200, 255, 255, 255);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();
                MySqlCommand comando = new MySqlCommand("select * from servicios where id="+ txtID.Text, Connection);
                MySqlDataReader lectura = comando.ExecuteReader();
                if (lectura.Read()){
                    txtNombServ.Text = lectura.GetString(1); txtNombServ.Enabled = true;
                    CmbTipoServ.SelectedItem=lectura.GetString(2); CmbTipoServ.Enabled = true;
                    txtDescrServ.Text = lectura.GetString(3); txtDescrServ.Enabled = true;
                    txtCostServ.Text = lectura.GetString(4); txtCostServ.Enabled = true;
                }
                Connection.Close();
            }
            catch (MySqlException error)
            {
                MessageBox.Show("Error de BD: " + error.Message);
                Connection.Close();
            }
            catch (InvalidOperationException error)
            {
                MessageBox.Show("Error de BD: " + error.Message);
                Connection.Close();
            }
        }

        private void BtnActuServ_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();
                MySqlCommand comando = new MySqlCommand("UPDATE servicios SET nombre = '"+ txtNombServ.Text + "', tipo = '"+ CmbTipoServ.SelectedItem + "', descripcion = '"+ txtDescrServ.Text + "', Costo = "+ txtCostServ.Text + " where id=" + txtID.Text, Connection);
                MySqlDataReader lectura = comando.ExecuteReader();
                MessageBox.Show(null, "Servicio actualizado", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Connection.Close();
            }
            catch (MySqlException error)
            {
                MessageBox.Show(null, "Error "+error.Code+" :"+error.Message, "Error");
            }
            catch (InvalidOperationException error)
            {
                MessageBox.Show(null, "Error " + error.HResult + " :" + error.Message, "Error");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            txtNombServ.Text = ""; txtNombServ.Enabled = false;
            CmbTipoServ.SelectedItem = ""; CmbTipoServ.Enabled = false;
            txtDescrServ.Text = ""; txtDescrServ.Enabled = false;
            txtCostServ.Text = ""; txtCostServ.Enabled = false;
            txtNombServ.Focus();
        }
    }
}
