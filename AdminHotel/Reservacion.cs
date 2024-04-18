using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminHotel
{
    internal class Reservacion
    {
        public int ReservasID { get; set; }
        public int ClienteID { get; set; }
        public int HabitacionID { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public decimal Precio { get; set; }
        public bool Confirmada { get; set; }
        public string EstatusPago { get; set; }

        public Reservacion() 
        {
        }

        public Reservacion(int reservasID, int clienteID, int habitacionID, DateTime fechaInicio, DateTime fechaFin, decimal precio, bool confirmada, string estatusPago)
        {
            this.ReservasID = reservasID;
            this.ClienteID = clienteID;
            this.HabitacionID = habitacionID;
            this.FechaInicio = fechaInicio;
            this.FechaFin = fechaFin;
            this.Precio = precio;
            this.Confirmada = confirmada;
            this.EstatusPago = estatusPago;
        }
        //public void MostrarInfo()
        //{
        //    string descripcion = "";
        //    descripcion = string.Format("ReservasID: {0}, ClienteID: {1}, HabitacionID: {2}, FechaInicio: {3}, FechaFin: {4}, Precio: {5}, Confirmada: {6}, EstatusPago:{7}", this.ReservasID, this.ClienteID, this.HabitacionID, this.FechaInicio, this.FechaFin, this.Precio, this.Confirmada, this.EstatusPago);
        //    MessageBox.Show(descripcion, "Informacion producto");
        //}
        public DataSet ConsultaReservas()
        {
            SqlConnection conexion = new SqlConnection("Server=25.7.247.173,1433;database=hotel;User Id=dev;Password=andres123;");
            SqlCommand cmd = new SqlCommand("ListarReservasPorCliente", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            conexion.Open();
            DataSet ds = new DataSet();
            da.Fill(ds);

            conexion.Close();

            return ds;
        }
    }

}
        
