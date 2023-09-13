using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace U4_W3_D2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Verifica delle credenziali dal web.config
            string expectedUsername = ConfigurationManager.AppSettings["Username"];
            string expectedPassword = ConfigurationManager.AppSettings["Password"];

            if (username == expectedUsername && password == expectedPassword)
            {
                // Login riuscito, reinderizza all'altro WebForm
                Session["LoggedInUser"] = username;
                Response.Redirect("TicketBookingForm.aspx");
            }
            else
            {
                // Login Fallito
                lblErrorMessage.Text = "Credenziali non valide. Riprova.";
                lblErrorMessage.Visible = true;
            }
        }
    }
}