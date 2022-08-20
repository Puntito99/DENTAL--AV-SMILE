﻿
namespace C_Presentacion.Servicios
{
    partial class ConsultarServicio
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnConsul = new FontAwesome.Sharp.IconButton();
            this.BtnAtras = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreServ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoServ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescrServ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioServ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(124)))), ((int)(((byte)(178)))));
            this.panel2.BackgroundImage = global::C_Presentacion.Properties.Resources.FondoAlter2;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.BtnConsul);
            this.panel2.Controls.Add(this.BtnAtras);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(533, 409);
            this.panel2.TabIndex = 15;
            // 
            // BtnConsul
            // 
            this.BtnConsul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.BtnConsul.FlatAppearance.BorderSize = 0;
            this.BtnConsul.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnConsul.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsul.ForeColor = System.Drawing.Color.White;
            this.BtnConsul.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.BtnConsul.IconColor = System.Drawing.Color.White;
            this.BtnConsul.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnConsul.IconSize = 35;
            this.BtnConsul.Location = new System.Drawing.Point(100, 332);
            this.BtnConsul.Name = "BtnConsul";
            this.BtnConsul.Size = new System.Drawing.Size(151, 45);
            this.BtnConsul.TabIndex = 17;
            this.BtnConsul.Text = "Consultar";
            this.BtnConsul.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConsul.UseVisualStyleBackColor = false;
            // 
            // BtnAtras
            // 
            this.BtnAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.BtnAtras.FlatAppearance.BorderSize = 0;
            this.BtnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAtras.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtras.ForeColor = System.Drawing.Color.White;
            this.BtnAtras.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.BtnAtras.IconColor = System.Drawing.Color.White;
            this.BtnAtras.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnAtras.IconSize = 35;
            this.BtnAtras.Location = new System.Drawing.Point(266, 332);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(166, 45);
            this.BtnAtras.TabIndex = 18;
            this.BtnAtras.Text = "Cancelar";
            this.BtnAtras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAtras.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(53)))), ((int)(((byte)(103)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 25);
            this.panel1.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(175, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Consultar servicios";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.NombreServ,
            this.TipoServ,
            this.DescrServ,
            this.PrecioServ});
            this.dataGridView1.Location = new System.Drawing.Point(27, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(494, 211);
            this.dataGridView1.TabIndex = 19;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            // 
            // NombreServ
            // 
            this.NombreServ.HeaderText = "Nombre";
            this.NombreServ.Name = "NombreServ";
            // 
            // TipoServ
            // 
            this.TipoServ.HeaderText = "Tipo";
            this.TipoServ.Name = "TipoServ";
            // 
            // DescrServ
            // 
            this.DescrServ.HeaderText = "Dscripción";
            this.DescrServ.Name = "DescrServ";
            // 
            // PrecioServ
            // 
            this.PrecioServ.HeaderText = "Precio";
            this.PrecioServ.Name = "PrecioServ";
            // 
            // ConsultarServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 434);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarServicio";
            this.Text = "ConsultarServicio";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton BtnConsul;
        private FontAwesome.Sharp.IconButton BtnAtras;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreServ;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoServ;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescrServ;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioServ;
    }
}