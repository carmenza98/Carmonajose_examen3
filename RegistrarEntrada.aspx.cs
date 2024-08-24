using System;
using System.Data.SqlClient;

public partial class RegistrarEntrada : System.Web.UI.Page
{
    protected void btnRegistrarEntrada_Click(object sender, EventArgs e)
    {
        // Obtener datos del formulario
        int viajeroID = int.Parse(txtViajeroID.Text);
        DateTime fechaEntrada = DateTime.Parse(txtFechaEntrada.Text);
        string lugarEntrada = txtLugarEntrada.Text;

        // Cadena de conexión desde Web.config
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString;

        // Consulta SQL para insertar la entrada
        string query = "INSERT INTO Entradas (ViajeroID, FechaEntrada, LugarEntrada) " +
                       "VALUES (@ViajeroID, @FechaEntrada, @LugarEntrada)";

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ViajeroID", viajeroID);
            cmd.Parameters.AddWithValue("@FechaEntrada", fechaEntrada);
            cmd.Parameters.AddWithValue("@LugarEntrada", lugarEntrada);

            conn.Open();
            cmd.ExecuteNonQuery();
            lblMensaje.Text = "Entrada registrada exitosamente.";
        }
    }
}
