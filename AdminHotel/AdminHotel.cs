using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminHotel
{
    public partial class AdminHotel : Form
    {
        int ReservasID = 0;


        public AdminHotel()
        {
            InitializeComponent();
        }

        private void BtnReservas_Click(object sender, EventArgs e)
        {
            Reservacion resv = new Reservacion();
            DataSet ds = resv.ConsultaReservas();
            dataGVReservaciones.DataSource  = ds.Tables[0];

        }

        private void dataGVReservaciones_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            try
            {
                int rowIndex = this.dataGVReservaciones.CurrentRow.Index;

                this.ReservasID = int.Parse(this.dataGVReservaciones.Rows[rowIndex].Cells[0].Value.ToString());

                TablaReservas form = new TablaReservas(ReservasID);
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            ClientesAlta clientesAltaForm = new ClientesAlta(0);
            clientesAltaForm.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            TablaClientes tablaClientes = new TablaClientes(0);
            tablaClientes.Show();   
        }
    }
}
