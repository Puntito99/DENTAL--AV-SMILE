
namespace C_Presentacion.Servicios
{
    partial class eliminarServicio
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
            this.txtIdServ = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblConfirma = new System.Windows.Forms.Label();
            this.panelT = new System.Windows.Forms.Panel();
            this.BtnElServ = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.label4.Size = new System.Drawing.Size(163, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Deshabilitar servicio";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código del servicio";
            // 
            // txtIdServ
            // 
            this.txtIdServ.Location = new System.Drawing.Point(184, 18);
            this.txtIdServ.Name = "txtIdServ";
            this.txtIdServ.Size = new System.Drawing.Size(140, 20);
            this.txtIdServ.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(124)))), ((int)(((byte)(178)))));
            this.panel2.BackgroundImage = global::C_Presentacion.Properties.Resources.FondoAlter2;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panelT);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(551, 396);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblConfirma);
            this.panel3.Location = new System.Drawing.Point(31, 106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(484, 221);
            this.panel3.TabIndex = 21;
            // 
            // lblConfirma
            // 
            this.lblConfirma.AutoSize = true;
            this.lblConfirma.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirma.Location = new System.Drawing.Point(3, 9);
            this.lblConfirma.Name = "lblConfirma";
            this.lblConfirma.Size = new System.Drawing.Size(237, 21);
            this.lblConfirma.TabIndex = 6;
            this.lblConfirma.Text = "Esperando input del usuario...";
            // 
            // panelT
            // 
            this.panelT.BackColor = System.Drawing.Color.White;
            this.panelT.Controls.Add(this.txtIdServ);
            this.panelT.Controls.Add(this.BtnElServ);
            this.panelT.Controls.Add(this.label1);
            this.panelT.Location = new System.Drawing.Point(34, 34);
            this.panelT.Name = "panelT";
            this.panelT.Size = new System.Drawing.Size(484, 57);
            this.panelT.TabIndex = 20;
            // 
            // BtnElServ
            // 
            this.BtnElServ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.BtnElServ.FlatAppearance.BorderSize = 0;
            this.BtnElServ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnElServ.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnElServ.ForeColor = System.Drawing.Color.White;
            this.BtnElServ.IconChar = FontAwesome.Sharp.IconChar.X;
            this.BtnElServ.IconColor = System.Drawing.Color.White;
            this.BtnElServ.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnElServ.IconSize = 35;
            this.BtnElServ.Location = new System.Drawing.Point(330, 3);
            this.BtnElServ.Name = "BtnElServ";
            this.BtnElServ.Size = new System.Drawing.Size(151, 45);
            this.BtnElServ.TabIndex = 5;
            this.BtnElServ.Text = "Eliminar";
            this.BtnElServ.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnElServ.UseVisualStyleBackColor = false;
            this.BtnElServ.Click += new System.EventHandler(this.BtnActuServ_Click);
            // 
            // eliminarServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 421);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "eliminarServicio";
            this.Text = "NuevoServicio";
            this.Load += new System.EventHandler(this.eliminarServicio_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelT.ResumeLayout(false);
            this.panelT.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdServ;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton BtnElServ;
        private System.Windows.Forms.Panel panelT;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblConfirma;
    }
}