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
    public partial class ClientesAlta : Form
    {
        int clienteID = 0;

        public ClientesAlta(int clienteID)
        {
            InitializeComponent();

            this.clienteID = clienteID;
            if (clienteID > 0) 
            {
                FillTextBoxes(clienteID);
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtNombre.Text == "" || string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("Debe ingresar un nombre", "Info");
                    return;
                }

                if (txtApellidoPat.Text == "" || string.IsNullOrWhiteSpace(txtApellidoPat.Text))
                {
                    MessageBox.Show("Debe ingresar Apellido Paterno", "Info");
                    return;

                }

                if (txtApellidoMat.Text == "" || string.IsNullOrWhiteSpace(txtApellidoMat.Text))
                {
                    MessageBox.Show("Debe ingresar un Apellido Materno", "Info");
                    return;
                }

                if (txtEmail.Text == "" || string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Debe ingresar un Email", "Info");
                    return;
                }

                if (txtTelefono.Text == "" || string.IsNullOrWhiteSpace(txtTelefono.Text))
                {
                    MessageBox.Show("Debe ingresar un Telefono", "Info");
                    return;
                }

                Cliente cliente = new Cliente(this.clienteID, txtNombre.Text, txtApellidoPat.Text, txtApellidoMat.Text, txtEmail.Text, txtTelefono.Text, 0);
                string resultado = cliente.AltaCliente();

                MessageBox.Show(resultado, "Info");
                Limpiar();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar cliente: " + ex.Message, "Error");
            }
        }
        private void Limpiar()
        {
            txtNombre.Clear();
            txtApellidoPat.Clear();
            txtApellidoMat.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            clienteID = 0;
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        public void FillTextBoxes(int clienteID)
        {
            // Assuming you have a method to fetch client data from the database
            DataTable clientData = GetDataFromDatabase(clienteID);

            if (clientData != null && clientData.Rows.Count > 0)
            {
                DataRow row = clientData.Rows[0];
                lblNoCliente.Text = "No. cliente: " + row["ClienteID"].ToString();
                txtNombre.Text = row["Nombre"].ToString();
                txtApellidoPat.Text = row["ApellidoPaterno"].ToString();
                txtApellidoMat.Text = row["ApellidoMaterno"].ToString();
                txtEmail.Text = row["Email"].ToString();
                txtTelefono.Text = row["Telefono"].ToString();
            }
        }

        private DataTable GetDataFromDatabase(int clienteID)
        {
            Cliente cliente = new Cliente();
            var ds = cliente.ConsultaClientes(clienteID, null, null, null, null, null);

            
            return ds.Tables[0];

        }
    }
}
