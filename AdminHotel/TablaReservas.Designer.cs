namespace AdminHotel
{
    partial class TablaReservas
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
            this.dataGVDetallesResv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDetallesResv)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGVDetallesResv
            // 
            this.dataGVDetallesResv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGVDetallesResv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVDetallesResv.Location = new System.Drawing.Point(12, 95);
            this.dataGVDetallesResv.Name = "dataGVDetallesResv";
            this.dataGVDetallesResv.ReadOnly = true;
            this.dataGVDetallesResv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGVDetallesResv.Size = new System.Drawing.Size(891, 398);
            this.dataGVDetallesResv.TabIndex = 1;
            // 
            // TablaReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 505);
            this.Controls.Add(this.dataGVDetallesResv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TablaReservas";
            this.Text = "TablaReservas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDetallesResv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGVDetallesResv;
    }
}