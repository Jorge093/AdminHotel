using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminHotel
{
    public partial class TablaClientes : Form
    {
        int clienteID = 0;
        public TablaClientes(int clienteID)
        {
            InitializeComponent();
            this.clienteID = clienteID;
            DetallesClientes();
        }

        public void DetallesClientes()
        {
            try
            {
               
                Cliente cliente = new Cliente();
                DataSet ds = cliente.ConsultaClientes(0,
                                                      string.IsNullOrEmpty(txtNombre.Text) ? null : txtNombre.Text,
                                                      string.IsNullOrEmpty(txtApellidoPat.Text) ? null : txtApellidoPat.Text,
                                                      string.IsNullOrEmpty(txtApellidoMat.Text) ? null : txtApellidoMat.Text,
                                                      string.IsNullOrEmpty(txtEmail.Text) ? null : txtEmail.Text,
                                                      string.IsNullOrEmpty(txtTelefono.Text) ? null : txtTelefono.Text);

                dataGVTClientes.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void dataGVTClientes_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int rowIndex = dataGVTClientes.CurrentRow.Index;
                int ClienteID = Convert.ToInt32(dataGVTClientes.Rows[rowIndex].Cells[0].Value);
                ClientesAlta clientesAltaForm = new ClientesAlta(ClienteID);
                clientesAltaForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            DetallesClientes();
        }
    }
}
