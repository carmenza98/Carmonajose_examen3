using System;

public partial class Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            lblWelcomeMessage.Text = "Bienvenido a la aplicación de gestión de viajeros. Hoy es " + DateTime.Now.ToString("D");
        }
    }
}
