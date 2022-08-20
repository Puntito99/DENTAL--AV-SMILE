
namespace C_Presentacion.BodegaYProductos
{
    partial class RegistrarProducto
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtDescrServ = new System.Windows.Forms.TextBox();
            this.txtCostServ = new System.Windows.Forms.TextBox();
            this.txtNomServ = new System.Windows.Forms.TextBox();
            this.CmbTipoServ = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.BtnActuServ = new FontAwesome.Sharp.IconButton();
            this.BtnLimpiar = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(124)))), ((int)(((byte)(178)))));
            this.panel2.BackgroundImage = global::C_Presentacion.Properties.Resources.FondoAlter2;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.Controls.Add(this.BtnActuServ);
            this.panel2.Controls.Add(this.BtnLimpiar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(549, 448);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.txtDescrServ);
            this.panel3.Controls.Add(this.txtCostServ);
            this.panel3.Controls.Add(this.txtNomServ);
            this.panel3.Controls.Add(this.CmbTipoServ);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(34, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(484, 261);
            this.panel3.TabIndex = 20;
            // 
            // txtDescrServ
            // 
            this.txtDescrServ.Location = new System.Drawing.Point(201, 110);
            this.txtDescrServ.Multiline = true;
            this.txtDescrServ.Name = "txtDescrServ";
            this.txtDescrServ.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescrServ.Size = new System.Drawing.Size(245, 84);
            this.txtDescrServ.TabIndex = 9;
            // 
            // txtCostServ
            // 
            this.txtCostServ.Location = new System.Drawing.Point(201, 215);
            this.txtCostServ.Name = "txtCostServ";
            this.txtCostServ.Size = new System.Drawing.Size(165, 20);
            this.txtCostServ.TabIndex = 8;
            // 
            // txtNomServ
            // 
            this.txtNomServ.Location = new System.Drawing.Point(201, 18);
            this.txtNomServ.Name = "txtNomServ";
            this.txtNomServ.Size = new System.Drawing.Size(165, 20);
            this.txtNomServ.TabIndex = 7;
            // 
            // CmbTipoServ
            // 
            this.CmbTipoServ.FormattingEnabled = true;
            this.CmbTipoServ.Location = new System.Drawing.Point(201, 65);
            this.CmbTipoServ.Name = "CmbTipoServ";
            this.CmbTipoServ.Size = new System.Drawing.Size(165, 21);
            this.CmbTipoServ.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantidad";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del producto";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton1.IconSize = 35;
            this.iconButton1.Location = new System.Drawing.Point(365, 332);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(166, 45);
            this.iconButton1.TabIndex = 19;
            this.iconButton1.Text = "Cancelar";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
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
            this.BtnActuServ.Location = new System.Drawing.Point(19, 332);
            this.BtnActuServ.Name = "BtnActuServ";
            this.BtnActuServ.Size = new System.Drawing.Size(151, 45);
            this.BtnActuServ.TabIndex = 17;
            this.BtnActuServ.Text = "Guardar";
            this.BtnActuServ.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnActuServ.UseVisualStyleBackColor = false;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.BtnLimpiar.FlatAppearance.BorderSize = 0;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLimpiar.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.BtnLimpiar.IconColor = System.Drawing.Color.White;
            this.BtnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnLimpiar.IconSize = 35;
            this.BtnLimpiar.Location = new System.Drawing.Point(185, 332);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(166, 45);
            this.BtnLimpiar.TabIndex = 18;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(53)))), ((int)(((byte)(103)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 25);
            this.panel1.TabIndex = 14;
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
            // 
            // RegistrarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 473);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarProducto";
            this.Text = "RegistrarProducto";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtDescrServ;
        private System.Windows.Forms.TextBox txtCostServ;
        private System.Windows.Forms.TextBox txtNomServ;
        private System.Windows.Forms.ComboBox CmbTipoServ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton BtnActuServ;
        private FontAwesome.Sharp.IconButton BtnLimpiar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}