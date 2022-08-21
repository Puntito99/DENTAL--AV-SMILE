
namespace C_Presentacion.Servicios
{
    partial class EditarServicio
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
            this.panelEditServ = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescrServ = new System.Windows.Forms.TextBox();
            this.txtCostServ = new System.Windows.Forms.TextBox();
            this.txtNombServ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnActuServ = new FontAwesome.Sharp.IconButton();
            this.BtnCancelar = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.CmbTipoServ = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panelEditServ.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.BackgroundImage = global::C_Presentacion.Properties.Resources.FondoAlter2;
            this.panel2.Controls.Add(this.panelEditServ);
            this.panel2.Controls.Add(this.BtnActuServ);
            this.panel2.Controls.Add(this.BtnCancelar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(551, 396);
            this.panel2.TabIndex = 15;
            // 
            // panelEditServ
            // 
            this.panelEditServ.BackColor = System.Drawing.Color.White;
            this.panelEditServ.Controls.Add(this.txtID);
            this.panelEditServ.Controls.Add(this.CmbTipoServ);
            this.panelEditServ.Controls.Add(this.iconButton1);
            this.panelEditServ.Controls.Add(this.label6);
            this.panelEditServ.Controls.Add(this.txtDescrServ);
            this.panelEditServ.Controls.Add(this.txtCostServ);
            this.panelEditServ.Controls.Add(this.txtNombServ);
            this.panelEditServ.Controls.Add(this.label5);
            this.panelEditServ.Controls.Add(this.label3);
            this.panelEditServ.Controls.Add(this.label2);
            this.panelEditServ.Controls.Add(this.label1);
            this.panelEditServ.Location = new System.Drawing.Point(27, 19);
            this.panelEditServ.Name = "panelEditServ";
            this.panelEditServ.Size = new System.Drawing.Size(498, 285);
            this.panelEditServ.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Código";
            // 
            // txtDescrServ
            // 
            this.txtDescrServ.Enabled = false;
            this.txtDescrServ.Location = new System.Drawing.Point(183, 143);
            this.txtDescrServ.Multiline = true;
            this.txtDescrServ.Name = "txtDescrServ";
            this.txtDescrServ.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescrServ.Size = new System.Drawing.Size(245, 84);
            this.txtDescrServ.TabIndex = 5;
            // 
            // txtCostServ
            // 
            this.txtCostServ.Enabled = false;
            this.txtCostServ.Location = new System.Drawing.Point(183, 248);
            this.txtCostServ.Name = "txtCostServ";
            this.txtCostServ.Size = new System.Drawing.Size(165, 20);
            this.txtCostServ.TabIndex = 6;
            // 
            // txtNombServ
            // 
            this.txtNombServ.Enabled = false;
            this.txtNombServ.Location = new System.Drawing.Point(183, 66);
            this.txtNombServ.Name = "txtNombServ";
            this.txtNombServ.Size = new System.Drawing.Size(165, 20);
            this.txtNombServ.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Costo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del servicio";
            // 
            // BtnActuServ
            // 
            this.BtnActuServ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.BtnActuServ.FlatAppearance.BorderSize = 0;
            this.BtnActuServ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnActuServ.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActuServ.ForeColor = System.Drawing.Color.White;
            this.BtnActuServ.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            this.BtnActuServ.IconColor = System.Drawing.Color.White;
            this.BtnActuServ.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnActuServ.IconSize = 35;
            this.BtnActuServ.Location = new System.Drawing.Point(107, 313);
            this.BtnActuServ.Name = "BtnActuServ";
            this.BtnActuServ.Size = new System.Drawing.Size(151, 45);
            this.BtnActuServ.TabIndex = 7;
            this.BtnActuServ.Text = "Actuzalizar";
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
            this.BtnCancelar.Location = new System.Drawing.Point(273, 313);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(166, 45);
            this.BtnCancelar.TabIndex = 8;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(53)))), ((int)(((byte)(103)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 25);
            this.panel1.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(201, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Editar servicio";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 35;
            this.iconButton1.Location = new System.Drawing.Point(277, 7);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(151, 45);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.Text = "Buscar";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // CmbTipoServ
            // 
            this.CmbTipoServ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoServ.Enabled = false;
            this.CmbTipoServ.FormattingEnabled = true;
            this.CmbTipoServ.Items.AddRange(new object[] {
            "Limpieza",
            "Ortodoncia",
            "Protesis"});
            this.CmbTipoServ.Location = new System.Drawing.Point(183, 99);
            this.CmbTipoServ.Name = "CmbTipoServ";
            this.CmbTipoServ.Size = new System.Drawing.Size(165, 21);
            this.CmbTipoServ.TabIndex = 4;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(183, 15);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(62, 20);
            this.txtID.TabIndex = 1;
            // 
            // EditarServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 421);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "EditarServicio";
            this.Text = "EditarServicio";
            this.Load += new System.EventHandler(this.EditarServicio_Load);
            this.panel2.ResumeLayout(false);
            this.panelEditServ.ResumeLayout(false);
            this.panelEditServ.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtDescrServ;
        private System.Windows.Forms.TextBox txtCostServ;
        private System.Windows.Forms.TextBox txtNombServ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelEditServ;
        private FontAwesome.Sharp.IconButton BtnActuServ;
        private FontAwesome.Sharp.IconButton BtnCancelar;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.ComboBox CmbTipoServ;
        private System.Windows.Forms.TextBox txtID;
    }
}