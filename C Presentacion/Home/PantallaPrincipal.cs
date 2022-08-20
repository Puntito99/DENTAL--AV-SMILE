using C_Presentacion.Servicios;
using C_Presentacion.Odontologo;
using C_Presentacion.Paciente;
using C_Presentacion.BodegaYProductos;
using C_Presentacion.Recepcionista;

using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Presentacion.Home
{
    public partial class PantallaPrincipal : Form
    {
        private IconButton currentbtn;
        private Panel LeftBorderBtn;
        private Form FormularioActivo = null;
        public String usuario;

        private struct RGBCOLORS
        {
            public static Color azulbajo = Color.FromArgb(24, 161, 251);
        }

        public PantallaPrincipal()
        {
            InitializeComponent();
            customdesign();
            LeftBorderBtn = new Panel();
            panelOpciones.Controls.Add(LeftBorderBtn);
        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {
            this.BtnNorm.Visible = false;
            this.lblusuario.Text = usuario;
        }

        private void customdesign()
        {
            this.OpcServicios.Visible = false;
            this.OpcCitas.Visible = false;
            this.OpcOdontologo.Visible = false;
            this.OpcPaciente.Visible = false;
            this.OpcRecepcionista.Visible = false;
            this.OpcBodProd.Visible = false;
        }
        private void hidesubmenu()
        {
            if (OpcServicios.Visible)
            {
                OpcServicios.Visible = false;
            }
            if (OpcCitas.Visible)
            {
                OpcCitas.Visible = false;
            }
            if (OpcOdontologo.Visible)
            {
                OpcOdontologo.Visible = false;
            }
            if (OpcPaciente.Visible)
            {
                OpcPaciente.Visible = false;
            }
            if (OpcRecepcionista.Visible)
            {
                OpcRecepcionista.Visible = false;
            }
            if (OpcBodProd.Visible)
            {
                OpcBodProd.Visible = false;
            }
        }

        private void showsubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hidesubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void ActivarBoton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                desactivarBoton();
                currentbtn = (IconButton)senderBtn;
                currentbtn.BackColor = Color.FromArgb(37, 36, 81);
                currentbtn.ForeColor = color;
                currentbtn.TextAlign = ContentAlignment.MiddleCenter;
                currentbtn.IconColor = color;
                currentbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentbtn.ImageAlign = ContentAlignment.MiddleRight;
                LeftBorderBtn.Size = new Size(7, currentbtn.Size.Height); //Size(7, x) ancho y alto del boton
                LeftBorderBtn.BackColor = color;
                LeftBorderBtn.Location = new Point(0, currentbtn.Location.Y);
                LeftBorderBtn.Visible = true;
                LeftBorderBtn.BringToFront();
            }
        }

        private void desactivarBoton()
        {
            if (currentbtn != null)
            {
                currentbtn.BackColor = Color.FromArgb(11, 53, 103);
                currentbtn.ForeColor = Color.White;
                currentbtn.TextAlign = ContentAlignment.MiddleCenter;
                currentbtn.IconColor = Color.White;
                currentbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentbtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        public void abrirhijoform(Form FrmHijo)
        {
            //Si existe formulairo abierto lo cerramos
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            //almacenamos el form abierto agregamos estilos y mostramos
            FormularioActivo = FrmHijo;
            FrmHijo.TopLevel = false;
            FrmHijo.FormBorderStyle = FormBorderStyle.None;
            FrmHijo.Dock = DockStyle.Fill;
            PanelForms.Controls.Add(FrmHijo);
            PanelForms.Tag = FrmHijo;
            FrmHijo.BringToFront();
            FrmHijo.Show();
        }

        private void BtnServicios_Click(object sender, EventArgs e)
        {
            showsubmenu(OpcServicios);
            ActivarBoton(sender, RGBCOLORS.azulbajo);
            
        }

        private void BtnCitas_Click(object sender, EventArgs e)
        {
            showsubmenu(OpcCitas);
            ActivarBoton(sender, RGBCOLORS.azulbajo); 
            
        }

        private void BtnOdontologo_Click(object sender, EventArgs e)
        {
            showsubmenu(OpcOdontologo);
            ActivarBoton(sender, RGBCOLORS.azulbajo);
            
        }

        private void BtnPaciente_Click(object sender, EventArgs e)
        {
            showsubmenu(OpcPaciente);
            ActivarBoton(sender, RGBCOLORS.azulbajo);
            
        }

        private void BtnRecepcionista_Click(object sender, EventArgs e)
        {
            showsubmenu(OpcRecepcionista);
            ActivarBoton(sender, RGBCOLORS.azulbajo);
            
        }

        private void BtnBodProd_Click(object sender, EventArgs e)
        {
            showsubmenu(OpcBodProd);
            ActivarBoton(sender, RGBCOLORS.azulbajo);
            
        }

        private void BtnSalir_MouseMove(object sender, MouseEventArgs e)
        {
            this.BtnSalir.IconColor = Color.RoyalBlue;
            this.BtnSalir.ForeColor = Color.RoyalBlue;
        }

        private void BtnSalir_MouseLeave(object sender, EventArgs e)
        {
            this.BtnSalir.IconColor = Color.White;
            this.BtnSalir.ForeColor = Color.White;
        }

        private void BtnNuevServ_Click(object sender, EventArgs e)
        {
            abrirhijoform(new NuevoServicio());
        }

        private void BtnModServ_Click(object sender, EventArgs e)
        {
            abrirhijoform(new EditarServicio());
        }

        private void BtnNuevCita_Click(object sender, EventArgs e)
        {

        }

        private void BtnCrearOdont_Click(object sender, EventArgs e)
        {
            abrirhijoform(new RegistrarOndontologo());
        }

        private void BtnNuevPac_Click(object sender, EventArgs e)
        {
            abrirhijoform(new RegistrarPaciente());
        }

        private void BtnRegProd_Click(object sender, EventArgs e)
        {
            abrirhijoform(new RegistrarProducto());
        }

        private void BtnNuevRecp_Click(object sender, EventArgs e)
        {
            abrirhijoform(new RegistrarRecepcionista());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtnMax.Visible = false;
            BtnNorm.Visible = true;
        }

        private void Btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnNorm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BtnMax.Visible = true;
            BtnNorm.Visible = false;
        }

        private void BtnConsPac_Click(object sender, EventArgs e)
        {
            abrirhijoform(new ConsultarPaciente());
        }

        private void BtnVerServ_Click(object sender, EventArgs e)
        {
            abrirhijoform(new ConsultarServicio());
        }

        private void BtnConsCita_Click(object sender, EventArgs e)
        {

        }

        private void BtnConsOdon_Click(object sender, EventArgs e)
        {
            abrirhijoform(new ConsultarOdontologo());
        }

        private void BtnEditRecp_Click(object sender, EventArgs e)
        {
            abrirhijoform(new EditarRecepcionista());
        }

        private void BtnVerRec_Click(object sender, EventArgs e)
        {
            abrirhijoform(new ConsultarRecepcionista());
        }

        private void BtnEditOdont_Click(object sender, EventArgs e)
        {
            abrirhijoform(new EditarOdontologo());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            try
            {
                Login l = new Login();
                l.Show();
            }
            catch (NullReferenceException error)
            {
                MessageBox.Show( error.Message);
            }
        }

        private void BtnDeshServ_Click(object sender, EventArgs e)
        {
            abrirhijoform(new eliminarServicio());
        }
    }
}
