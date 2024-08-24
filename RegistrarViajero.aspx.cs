using System;
using System.Data.SqlClient;

public partial class RegistrarViajero : System.Web.UI.Page
{
    protected void btnRegistrar_Click(object sender, EventArgs e)
    {
        // Obtener datos del formulario
        string nombre = txtNombre.Text;
        string apellido = txtApellido.Text;
        string pasaporte = txtPasaporte.Text;
        DateTime fechaNacimiento = DateTime.Parse(txtFechaNacimiento.Text);
        string nacionalidad = txtNacionalidad.Text;

        // Cadena de conexión desde Web.config
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString;

        // Consulta SQL para insertar el viajero
        string query = "INSERT INTO Viajeros (Nombre, Apellido, Pasaporte, FechaNacimiento, Nacionalidad) " +
                       "VALUES (@Nombre, @Apellido, @Pasaporte, @FechaNacimiento, @Nacionalidad)";

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Nombre", nombre);
            cmd.Parameters.AddWithValue("@Apellido", apellido);
            cmd.Parameters.AddWithValue("@Pasaporte", pasaporte);
            cmd.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);
            cmd.Parameters.AddWithValue("@Nacionalidad", nacionalidad);

            conn.Open();
            cmd.ExecuteNonQuery();
            lblMensaje.Text = "Viajero registrado exitosamente.";
        }
    }
}
