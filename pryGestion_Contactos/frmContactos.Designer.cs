namespace pryGestion_Contactos
{
    partial class frmContactos
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvContactos = new System.Windows.Forms.DataGridView();
            this.btnCargar = new System.Windows.Forms.Button();
            this.gpbContactos = new System.Windows.Forms.GroupBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).BeginInit();
            this.gpbContactos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.panel3.Controls.Add(this.dgvContactos);
            this.panel3.Controls.Add(this.btnCargar);
            this.panel3.Controls.Add(this.gpbContactos);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(740, 487);
            this.panel3.TabIndex = 3;
            // 
            // dgvContactos
            // 
            this.dgvContactos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactos.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvContactos.Location = new System.Drawing.Point(274, 0);
            this.dgvContactos.Name = "dgvContactos";
            this.dgvContactos.Size = new System.Drawing.Size(466, 487);
            this.dgvContactos.TabIndex = 3;
            this.dgvContactos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvContactos_CellFormatting);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(12, 343);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(244, 59);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "Cargar Nuevo";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // gpbContactos
            // 
            this.gpbContactos.Controls.Add(this.lblCategoria);
            this.gpbContactos.Controls.Add(this.cmbCategoria);
            this.gpbContactos.Controls.Add(this.lblMail);
            this.gpbContactos.Controls.Add(this.lblTelefono);
            this.gpbContactos.Controls.Add(this.lblApellido);
            this.gpbContactos.Controls.Add(this.txtMail);
            this.gpbContactos.Controls.Add(this.txtNumero);
            this.gpbContactos.Controls.Add(this.txtApellido);
            this.gpbContactos.Controls.Add(this.txtNombre);
            this.gpbContactos.Controls.Add(this.lblNombre);
            this.gpbContactos.Location = new System.Drawing.Point(12, 31);
            this.gpbContactos.Name = "gpbContactos";
            this.gpbContactos.Size = new System.Drawing.Size(244, 287);
            this.gpbContactos.TabIndex = 1;
            this.gpbContactos.TabStop = false;
            this.gpbContactos.Text = "Nuevo Contacto";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(224)))), ((int)(((byte)(210)))));
            this.lblCategoria.Location = new System.Drawing.Point(7, 249);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 9;
            this.lblCategoria.Text = "Categoria:";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(68, 241);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoria.TabIndex = 8;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(224)))), ((int)(((byte)(210)))));
            this.lblMail.Location = new System.Drawing.Point(7, 194);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(29, 13);
            this.lblMail.TabIndex = 7;
            this.lblMail.Text = "Mail:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(224)))), ((int)(((byte)(210)))));
            this.lblTelefono.Location = new System.Drawing.Point(7, 144);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(107, 13);
            this.lblTelefono.TabIndex = 6;
            this.lblTelefono.Text = "Numero de Telefono:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(224)))), ((int)(((byte)(210)))));
            this.lblApellido.Location = new System.Drawing.Point(7, 95);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 5;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(60, 187);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(118, 20);
            this.txtMail.TabIndex = 4;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(120, 137);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(118, 20);
            this.txtNumero.TabIndex = 3;
            this.txtNumero.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(60, 88);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(118, 20);
            this.txtApellido.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(60, 37);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(118, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(224)))), ((int)(((byte)(210)))));
            this.lblNombre.Location = new System.Drawing.Point(7, 44);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // frmContactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 487);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmContactos";
            this.Text = "frmContactos";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).EndInit();
            this.gpbContactos.ResumeLayout(false);
            this.gpbContactos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox gpbContactos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.DataGridView dgvContactos;
    }
}