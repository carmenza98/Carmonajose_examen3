using System;
using System.Data.SqlClient;
using System.Web.Security;

public partial class Login : System.Web.UI.Page
{
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        string usuario = txtUsuario.Text;  // Accede al control txtUsuario
        string password = txtPassword.Text;  // Accede al control txtPassword

        // Obtener la cadena de conexión desde Web.config
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString;

        // Consulta para verificar el usuario y la contraseña
        string query = "SELECT COUNT(*) FROM Usuarios WHERE Usuario=@Usuario AND Password=@Password";

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Usuario", usuario);
            cmd.Parameters.AddWithValue("@Password", password);

            conn.Open();
            int result = (int)cmd.ExecuteScalar();

            if (result > 0)
            {
                // Autenticación exitosa
                FormsAuthentication.RedirectFromLoginPage(usuario, false);
            }
            else
            {
                // Credenciales incorrectas
                lblMensaje.Text = "Usuario o contraseña incorrectos.";
            }
        }
    }
}
