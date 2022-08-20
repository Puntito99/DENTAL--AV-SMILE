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
    public partial class eliminarServicio : Form
    {
        public eliminarServicio()
        {
            InitializeComponent();
        }
        MySqlConnection Connection = new MySqlConnection("server = localhost ; user = root ; password = pierinita ; database = dent-av-smile ; INTEGRATED SECURITY = true");
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void eliminarServicio_Load(object sender, EventArgs e)
        {
            //this.panelT.BackColor = Color.FromArgb(200, 255, 255, 255);
        }

        private void BtnActuServ_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();
                MySqlCommand comando = new MySqlCommand("select * from servicios where id= @id ", Connection);
                comando.Parameters.AddWithValue("@id", txtIdServ.Text);
                MySqlDataReader lectura = comando.ExecuteReader();
                DialogResult conf=0;
                if (lectura.Read())
                {
                    String nombre = lectura.GetString(1);
                    String tipo = lectura.GetString(2);
                    String descripcion = lectura.GetString(3);
                    lblConfirma.Text = "ID: " + txtIdServ.Text +
                                     "\nNombre: "+nombre+
                                     "\nTipo: "+tipo+
                                     "\nDescripción: "+descripcion;
                    conf = MessageBox.Show("¿Desea borrar este servicio?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
                else
                {
                    lblConfirma.Text = "No existe servicio con ese ID.";
                }
                Connection.Close();

                Connection.Open();
                if (conf == DialogResult.Yes)
                {
                    MySqlCommand comando1 = new MySqlCommand("DELETE FROM servicios WHERE id=" + txtIdServ.Text, Connection);
                    comando1.ExecuteNonQuery();
                    MessageBox.Show("Servicio eliminado");
                }
                Connection.Close();
            }
            catch (MySqlException error)
            {
                MessageBox.Show("Error de BD: "+error.Message);
                Connection.Close();
            }
            catch (InvalidOperationException error)
            {
                MessageBox.Show("Error de BD: " + error.Message);
                Connection.Close();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
        }


    }
}
