namespace AdminHotel
{
    partial class AdminHotel
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGVReservaciones = new System.Windows.Forms.DataGridView();
            this.BtnReservas = new System.Windows.Forms.Button();
            this.btnAltaCliente = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVReservaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGVReservaciones
            // 
            this.dataGVReservaciones.AllowUserToAddRows = false;
            this.dataGVReservaciones.AllowUserToDeleteRows = false;
            this.dataGVReservaciones.AllowUserToResizeColumns = false;
            this.dataGVReservaciones.AllowUserToResizeRows = false;
            this.dataGVReservaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGVReservaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVReservaciones.Location = new System.Drawing.Point(12, 95);
            this.dataGVReservaciones.Name = "dataGVReservaciones";
            this.dataGVReservaciones.ReadOnly = true;
            this.dataGVReservaciones.RowTemplate.ReadOnly = true;
            this.dataGVReservaciones.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGVReservaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGVReservaciones.Size = new System.Drawing.Size(891, 398);
            this.dataGVReservaciones.TabIndex = 0;
            this.dataGVReservaciones.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGVReservaciones_RowHeaderMouseClick);
            // 
            // BtnReservas
            // 
            this.BtnReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReservas.Location = new System.Drawing.Point(788, 51);
            this.BtnReservas.Name = "BtnReservas";
            this.BtnReservas.Size = new System.Drawing.Size(80, 24);
            this.BtnReservas.TabIndex = 1;
            this.BtnReservas.Text = "Reservas";
            this.BtnReservas.UseVisualStyleBackColor = true;
            this.BtnReservas.Click += new System.EventHandler(this.BtnReservas_Click);
            // 
            // btnAltaCliente
            // 
            this.btnAltaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaCliente.Location = new System.Drawing.Point(702, 51);
            this.btnAltaCliente.Name = "btnAltaCliente";
            this.btnAltaCliente.Size = new System.Drawing.Size(80, 24);
            this.btnAltaCliente.TabIndex = 2;
            this.btnAltaCliente.Text = "Alta Cliente";
            this.btnAltaCliente.UseVisualStyleBackColor = true;
            this.btnAltaCliente.Click += new System.EventHandler(this.btnAltaCliente_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Location = new System.Drawing.Point(616, 51);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(80, 24);
            this.btnClientes.TabIndex = 3;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // AdminHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 505);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnAltaCliente);
            this.Controls.Add(this.BtnReservas);
            this.Controls.Add(this.dataGVReservaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AdminHotel";
            this.Text = "AdminHotel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGVReservaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGVReservaciones;
        private System.Windows.Forms.Button BtnReservas;
        private System.Windows.Forms.Button btnAltaCliente;
        private System.Windows.Forms.Button btnClientes;
    }
}

