
namespace C_Presentacion.Servicios
{
    partial class NuevoServicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbTipoServ = new System.Windows.Forms.ComboBox();
            this.txtNomServ = new System.Windows.Forms.TextBox();
            this.txtCostServ = new System.Windows.Forms.TextBox();
            this.txtDescrServ = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelT = new System.Windows.Forms.Panel();
            this.BtnActuServ = new FontAwesome.Sharp.IconButton();
            this.BtnCancelar = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelT.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(53)))), ((int)(((byte)(103)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 25);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(175, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Registrar nuevo servicio";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del servicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descripción";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Costo";
            // 
            // CmbTipoServ
            // 
            this.CmbTipoServ.FormattingEnabled = true;
            this.CmbTipoServ.Location = new System.Drawing.Point(184, 65);
            this.CmbTipoServ.Name = "CmbTipoServ";
            this.CmbTipoServ.Size = new System.Drawing.Size(165, 21);
            this.CmbTipoServ.TabIndex = 6;
            // 
            // txtNomServ
            // 
            this.txtNomServ.Location = new System.Drawing.Point(184, 18);
            this.txtNomServ.Name = "txtNomServ";
            this.txtNomServ.Size = new System.Drawing.Size(165, 20);
            this.txtNomServ.TabIndex = 7;
            // 
            // txtCostServ
            // 
            this.txtCostServ.Location = new System.Drawing.Point(184, 215);
            this.txtCostServ.Name = "txtCostServ";
            this.txtCostServ.Size = new System.Drawing.Size(165, 20);
            this.txtCostServ.TabIndex = 8;
            // 
            // txtDescrServ
            // 
            this.txtDescrServ.Location = new System.Drawing.Point(184, 110);
            this.txtDescrServ.Multiline = true;
            this.txtDescrServ.Name = "txtDescrServ";
            this.txtDescrServ.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescrServ.Size = new System.Drawing.Size(245, 84);
            this.txtDescrServ.TabIndex = 9;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(124)))), ((int)(((byte)(178)))));
            this.panel2.BackgroundImage = global::C_Presentacion.Properties.Resources.FondoAlter2;
            this.panel2.Controls.Add(this.panelT);
            this.panel2.Controls.Add(this.BtnActuServ);
            this.panel2.Controls.Add(this.BtnCancelar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(551, 396);
            this.panel2.TabIndex = 13;
            // 
            // panelT
            // 
            this.panelT.BackColor = System.Drawing.Color.White;
            this.panelT.Controls.Add(this.txtDescrServ);
            this.panelT.Controls.Add(this.txtCostServ);
            this.panelT.Controls.Add(this.txtNomServ);
            this.panelT.Controls.Add(this.CmbTipoServ);
            this.panelT.Controls.Add(this.label5);
            this.panelT.Controls.Add(this.label3);
            this.panelT.Controls.Add(this.label2);
            this.panelT.Controls.Add(this.label1);
            this.panelT.Location = new System.Drawing.Point(34, 34);
            this.panelT.Name = "panelT";
            this.panelT.Size = new System.Drawing.Size(484, 261);
            this.panelT.TabIndex = 20;
            // 
            // BtnActuServ
            // 
            this.BtnActuServ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.BtnActuServ.FlatAppearance.BorderSize = 0;
            this.BtnActuServ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnActuServ.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActuServ.ForeColor = System.Drawing.Color.White;
            this.BtnActuServ.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.BtnActuServ.IconColor = System.Drawing.Color.White;
            this.BtnActuServ.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnActuServ.IconSize = 35;
            this.BtnActuServ.Location = new System.Drawing.Point(103, 314);
            this.BtnActuServ.Name = "BtnActuServ";
            this.BtnActuServ.Size = new System.Drawing.Size(151, 45);
            this.BtnActuServ.TabIndex = 17;
            this.BtnActuServ.Text = "Guardar";
            this.BtnActuServ.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnActuServ.UseVisualStyleBackColor = false;
            this.BtnActuServ.Click += new System.EventHandler(this.BtnActuServ_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancelar.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.BtnCancelar.IconColor = System.Drawing.Color.White;
            this.BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnCancelar.IconSize = 35;
            this.BtnCancelar.Location = new System.Drawing.Point(269, 314);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(166, 45);
            this.BtnCancelar.TabIndex = 18;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // NuevoServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 421);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevoServicio";
            this.Text = "NuevoServicio";
            this.Load += new System.EventHandler(this.NuevoServicio_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panelT.ResumeLayout(false);
            this.panelT.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbTipoServ;
        private System.Windows.Forms.TextBox txtNomServ;
        private System.Windows.Forms.TextBox txtCostServ;
        private System.Windows.Forms.TextBox txtDescrServ;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton BtnActuServ;
        private FontAwesome.Sharp.IconButton BtnCancelar;
        private System.Windows.Forms.Panel panelT;
    }
}