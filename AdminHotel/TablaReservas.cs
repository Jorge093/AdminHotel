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
    public partial class TablaReservas : Form
    {
        public TablaReservas(int reservaId)
        {
            InitializeComponent();
            DetallesReservas(reservaId);
        }
        public void DetallesReservas(int reservasID)
        { 
            dataGVDetallesResv.Rows.Clear();
            SqlConnection conexion = new SqlConnection("Server=25.7.247.173,1433;database=hotel;User Id=dev;Password=andres123;");
            SqlCommand cmd = new SqlCommand("DetallePagoReserva", conexion);
            cmd.Parameters.Add(new SqlParameter("@ReservaID", reservasID));
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            conexion.Open();
            DataSet ds = new DataSet();
            da.Fill(ds);
            conexion.Close();

            dataGVDetallesResv.DataSource = ds.Tables[0].DefaultView;
        }
    }
}
