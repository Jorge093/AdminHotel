namespace AdminHotel
{
    partial class TablaClientes
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
            this.dataGVTClientes = new System.Windows.Forms.DataGridView();
            this.Telefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.ApellidoMaterno = new System.Windows.Forms.Label();
            this.txtApellidoMat = new System.Windows.Forms.TextBox();
            this.txtApellidoPat = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.ApellidoPaterno = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVTClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGVTClientes
            // 
            this.dataGVTClientes.AllowUserToAddRows = false;
            this.dataGVTClientes.AllowUserToDeleteRows = false;
            this.dataGVTClientes.AllowUserToResizeColumns = false;
            this.dataGVTClientes.AllowUserToResizeRows = false;
            this.dataGVTClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGVTClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVTClientes.Location = new System.Drawing.Point(12, 95);
            this.dataGVTClientes.Name = "dataGVTClientes";
            this.dataGVTClientes.ReadOnly = true;
            this.dataGVTClientes.RowTemplate.ReadOnly = true;
            this.dataGVTClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGVTClientes.Size = new System.Drawing.Size(891, 398);
            this.dataGVTClientes.TabIndex = 0;
            this.dataGVTClientes.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGVTClientes_RowHeaderMouseClick);
            // 
            // Telefono
            // 
            this.Telefono.AutoSize = true;
            this.Telefono.Location = new System.Drawing.Point(356, 43);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(49, 13);
            this.Telefono.TabIndex = 20;
            this.Telefono.Text = "Telefono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(443, 40);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(194, 20);
            this.txtTelefono.TabIndex = 19;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(122, 64);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(194, 20);
            this.txtEmail.TabIndex = 18;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(30, 67);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 13);
            this.Email.TabIndex = 17;
            this.Email.Text = "Email";
            // 
            // ApellidoMaterno
            // 
            this.ApellidoMaterno.AutoSize = true;
            this.ApellidoMaterno.Location = new System.Drawing.Point(30, 43);
            this.ApellidoMaterno.Name = "ApellidoMaterno";
            this.ApellidoMaterno.Size = new System.Drawing.Size(86, 13);
            this.ApellidoMaterno.TabIndex = 16;
            this.ApellidoMaterno.Text = "Apellido Materno";
            // 
            // txtApellidoMat
            // 
            this.txtApellidoMat.Location = new System.Drawing.Point(122, 40);
            this.txtApellidoMat.Name = "txtApellidoMat";
            this.txtApellidoMat.Size = new System.Drawing.Size(194, 20);
            this.txtApellidoMat.TabIndex = 15;
            // 
            // txtApellidoPat
            // 
            this.txtApellidoPat.Location = new System.Drawing.Point(443, 14);
            this.txtApellidoPat.Name = "txtApellidoPat";
            this.txtApellidoPat.Size = new System.Drawing.Size(194, 20);
            this.txtApellidoPat.TabIndex = 14;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(122, 14);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(194, 20);
            this.txtNombre.TabIndex = 13;
            // 
            // ApellidoPaterno
            // 
            this.ApellidoPaterno.AutoSize = true;
            this.ApellidoPaterno.Location = new System.Drawing.Point(356, 17);
            this.ApellidoPaterno.Name = "ApellidoPaterno";
            this.ApellidoPaterno.Size = new System.Drawing.Size(84, 13);
            this.ApellidoPaterno.TabIndex = 12;
            this.ApellidoPaterno.Text = "Apellido Paterno";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(30, 14);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 11;
            this.Nombre.Text = "Nombre";
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Location = new System.Drawing.Point(693, 33);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.BtnFiltrar.TabIndex = 21;
            this.BtnFiltrar.Text = "Filtrar";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // TablaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 505);
            this.Controls.Add(this.BtnFiltrar);
            this.Controls.Add(this.Telefono);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.ApellidoMaterno);
            this.Controls.Add(this.txtApellidoMat);
            this.Controls.Add(this.txtApellidoPat);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.ApellidoPaterno);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.dataGVTClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TablaClientes";
            this.Text = "TablaClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGVTClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGVTClientes;
        private System.Windows.Forms.Label Telefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label ApellidoMaterno;
        private System.Windows.Forms.TextBox txtApellidoMat;
        private System.Windows.Forms.TextBox txtApellidoPat;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label ApellidoPaterno;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Button BtnFiltrar;
    }
}