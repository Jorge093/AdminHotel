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
    internal class Cliente
    {
        public int clienteID { get; set; }
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public int transaccionID { get; set; }

        public Cliente()
        {

        }

        public Cliente(int clienteID, string nombre, string apellidoPaterno, string apellidoMaterno, string email, string telefono, int transaccionID)
        {
            this.clienteID = clienteID;
            this.nombre = nombre;
            this.apellidoPaterno = apellidoPaterno;
            this.apellidoMaterno = apellidoMaterno;
            this.email = email;
            this.telefono = telefono;
            this.transaccionID = transaccionID;

        }

        public string AltaCliente()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection("Server=25.7.247.173,1433;database=hotel;User Id=dev;Password=andres123;"))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("ClienteAgregar", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (this.clienteID > 0)
                        cmd.Parameters.Add(new SqlParameter("@ClienteId", this.clienteID));

                    cmd.Parameters.Add(new SqlParameter("@Nombre", this.nombre));
                    cmd.Parameters.Add(new SqlParameter("@ApellidoPaterno", this.apellidoPaterno));
                    cmd.Parameters.Add(new SqlParameter("@ApellidoMaterno", this.apellidoMaterno));
                    cmd.Parameters.Add(new SqlParameter("@Email", this.email));
                    cmd.Parameters.Add(new SqlParameter("@Telefono", this.telefono));
                    cmd.Parameters.Add(new SqlParameter("@TransaccionId", 1));
                    cmd.ExecuteNonQuery();
                }
                return "Cliente agregado exitosamente.";
            }
            catch (Exception ex)
            {
                return "Error al agregar cliente: " + ex.Message;
            }
        }


        public DataSet ConsultaClientes(int clienteID, string nombre, string apellidoPaterno, string apellidoMaterno, string email, string telefono)
        {
            DataSet ds = new DataSet();
            SqlConnection conexion = new SqlConnection("Server=25.7.247.173,1433;database=hotel;User Id=dev;Password=andres123;");
            SqlCommand cmd = new SqlCommand("ClienteConsulta", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            
            if(clienteID > 0)
                cmd.Parameters.AddWithValue("@ClienteID", clienteID);
            cmd.Parameters.AddWithValue("@Nombre", nombre);
            cmd.Parameters.AddWithValue("@ApellidoPaterno", apellidoPaterno);
            cmd.Parameters.AddWithValue("@ApellidoMaterno", apellidoMaterno);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Telefono", telefono);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            conexion.Open();

            return ds;
        }
    }
}
