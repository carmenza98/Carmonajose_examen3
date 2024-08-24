using System;
using System.Data.SqlClient;

public partial class RegistrarSalida : System.Web.UI.Page
{
    protected void btnRegistrarSalida_Click(object sender, EventArgs e)
    {
        // Obtener datos del formulario
        int viajeroID = int.Parse(txtViajeroID.Text);
        DateTime fechaSalida = DateTime.Parse(txtFechaSalida.Text);
        string lugarSalida = txtLugarSalida.Text;

        // Cadena de conexión desde Web.config
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString;

        // Consulta SQL para insertar la salida
        string query = "INSERT INTO Salidas (ViajeroID, FechaSalida, LugarSalida) " +
                       "VALUES (@ViajeroID, @FechaSalida, @LugarSalida)";

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ViajeroID", viajeroID);
            cmd.Parameters.AddWithValue("@FechaSalida", fechaSalida);
            cmd.Parameters.AddWithValue("@LugarSalida", lugarSalida);

            conn.Open();
            cmd.ExecuteNonQuery();
            lblMensaje.Text = "Salida registrada exitosamente.";
        }
    }
}
