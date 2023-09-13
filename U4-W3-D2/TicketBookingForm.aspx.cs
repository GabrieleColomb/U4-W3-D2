using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace U4_W3_D2
{
    public partial class TicketBookingForm : System.Web.UI.Page
    {

        private int salaNordBigliettiVenduti = 0;
        private int salaEstBigliettiVenduti = 0;
        private int salaSudBigliettiVenduti = 0;
        private int bigliettiRidotti = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if (Session["Username"] != null)
                {
                    lblUsername.Text = "Benvenuto, " + Session["Username"].ToString();
                }

                // Inizializza le variabili di sessione per i conteggi se non sono già presenti
                if (Session["SalaNordBigliettiVenduti"] == null)
                {
                    Session["SalaNordBigliettiVenduti"] = 0;
                }

                if (Session["SalaEstBigliettiVenduti"] == null)
                {
                    Session["SalaEstBigliettiVenduti"] = 0;
                }

                if (Session["SalaSudBigliettiVenduti"] == null)
                {
                    Session["SalaSudBigliettiVenduti"] = 0;
                }

                if (Session["BigliettiRidotti"] == null)
                {
                    Session["BigliettiRidotti"] = 0;
                }
            }
        }

        protected void btnPrenota_Click(object sender, EventArgs e)
        {
            string salaSelezionata = ddlSala.SelectedValue;
            string tipoBiglietto = ddlTipoBiglietto.SelectedValue;

            // Recupera i conteggi dalla sessione
            int salaNordBigliettiVenduti = (int)Session["SalaNordBigliettiVenduti"];
            int salaEstBigliettiVenduti = (int)Session["SalaEstBigliettiVenduti"];
            int salaSudBigliettiVenduti = (int)Session["SalaSudBigliettiVenduti"];
            int bigliettiRidotti = (int)Session["BigliettiRidotti"];

            // Aggiorna i conteggi nella sessione
            if (salaSelezionata == "SALA NORD")
            {
                salaNordBigliettiVenduti++;
                Session["SalaNordBigliettiVenduti"] = salaNordBigliettiVenduti;
            }
            else if (salaSelezionata == "SALA EST")
            {
                salaEstBigliettiVenduti++;
                Session["SalaEstBigliettiVenduti"] = salaEstBigliettiVenduti;
            }
            else if (salaSelezionata == "SALA SUD")
            {
                salaSudBigliettiVenduti++;
                Session["SalaSudBigliettiVenduti"] = salaSudBigliettiVenduti;
            }

            if (tipoBiglietto == "Ridotto")
            {
                bigliettiRidotti++;
                Session["BigliettiRidotti"] = bigliettiRidotti;
            }

            // Aggiorna le etichette delle statistiche
            lblSalaNord.Text = "Biglietti venduti in SALA NORD: " + salaNordBigliettiVenduti;
            lblSalaEst.Text = "Biglietti venduti in SALA EST: " + salaEstBigliettiVenduti;
            lblSalaSud.Text = "Biglietti venduti in SALA SUD: " + salaSudBigliettiVenduti;
            lblRidotto.Text = "Biglietti ridotti venduti: " + bigliettiRidotti;
        }
    }
}