using System;

public class Cliente
{
	public Cliente()
	{

    public int clienteID { get; set; }
    public string nombre { get; set; }
    public string apellidoPaterno { get; set; }
    public string apellidoMaterno { get; set; }
    public string email { get; set; }
    public string telefono { get; set; }

    public Cliente()
    {

    }
    public Cliente(int clienteID, string nombre, string apellidoPaterno, string apellidoMaterno, string email, string telefono)
    {
        this.clienteID = clienteID;
        this.nombre = nombre;   
        this.apellidoPaterno = apellidoPaterno; 
        this.apellidoMaterno = apellidoMaterno;
        this.email = email;
        this.telefono = telefono;
    }

    public string AltaCliente()
    {

        SqlConnection conexion = new SqlConnection("Server="";database="";User Id="";Password="";");
        SqlCommand cmd = new SqlCommand("ClienteAgregarActualizar", conexion);
        cmd.CommandType = CommandType.StoredProcedure;

        if (clienteID > 0)
            cmd.Parameters.Add(new SqlParameter("@ClienteID", this.clienteID));

        cmd.Parameters.Add(new SqlParameter("@Nombre", this.nombre));
        cmd.Parameters.Add(new SqlParameter("@ApellidoPaterno", this.apellidoPaterno));
        cmd.Parameters.Add(new SqlParameter("@ApellidoMaterno", this.apellidoMaterno));
        cmd.Parameters.Add(new SqlParameter("@Email", this.email));
        cmd.Parameters.Add(new SqlParameter("@Telefono", this.telefono));

        conexion.Open();
        cmd.ExecuteNonQuery();
        conexion.Close();

        return "Cliente agregado";
    }

    public string ConsultaClientes()
    {
        SqlConnection conexion = new SqlConnection("Server="";database="";User Id="";Password="";");
        SqlCommand cmd = new SqlCommand("ClienteConsultarActualizar", conexion);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        conexion.Open();
        DataSet ds = new DataSet();
        da.Fill(ds);

        conexion.Close();

        return ds;
    }
