using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NivelAccesDate;
using LibrarieModele;
using System.Windows.Forms;

namespace InterfazaUtilizator_WindowsForms
{
    public partial class PaginaClienti : UserControl
    {
        IStocareClienti adminClienti = StocareFactory.GetAdministratorStocareClienti();
        List<Client> clienti;
        public PaginaClienti()
        {
            InitializeComponent();
            clienti = adminClienti.GetClienti();

        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            string numeComplet;
            if (txtNumeClient.Text == "" || txtPrenumeClient.Text == "" || txtCNPClient.Text == "" || txtIDClient.Text =="")
                lblMesaj.Text = "Completati toate campurile!";
            else
            { 
            numeComplet = txtNumeClient.Text + "," + txtPrenumeClient.Text + "," + txtCNPClient.Text + "," + int.Parse(txtIDClient.Text);  
                Client _client = new Client(numeComplet);
                lblMesaj.Text = "Adaugare realizata cu succes!";
                clienti.Add(_client);
                //Adaugare client in fisier
                adminClienti.AddClient(_client);
            }
            
        }

        private void btnAfisare_Click(object sender, EventArgs e)
        {
            rtbAfiseazaClienti.Clear();
            //parcurgere colectie de obiecte 'Clienti'
            foreach (Client c in adminClienti.GetClienti())
            {
                rtbAfiseazaClienti.AppendText(c.ConversieLaSir()+"\n");
                rtbAfiseazaClienti.AppendText(Environment.NewLine);
            }
        }

        private void btnCautare_Click(object sender, EventArgs e)
        {
            Client client_cautat;
            if (txtCautareNumeClient.Text == "" || txtCautarePrenumeClient.Text == "")
                lblMesaj2.Text = "Completati toate campurile!";
            else
            {
                client_cautat = adminClienti.GetClient(txtCautareNumeClient.Text, txtCautarePrenumeClient.Text);
                if (client_cautat == null)
                    lblMesaj2.Text = "Clientul nu a fost gasit!";
                else
                {
                    rtbAfiseazaClienti.Clear();
                    lblMesaj2.Text = "Clientul a fost gasit!";
                    rtbAfiseazaClienti.AppendText(client_cautat.ConversieLaSir());
                }
            }
        }

        private void btnModificare_Click(object sender, EventArgs e)
        {
            Client client_cautat;
            if (txtCautareNumeClient.Text == "" || txtCautarePrenumeClient.Text == "")
                lblMesaj2.Text = "Completati toate campurile!";
            else
            {
                client_cautat = adminClienti.GetClient(txtCautareNumeClient.Text, txtCautarePrenumeClient.Text);
                if (client_cautat == null)
                    lblMesaj2.Text = "Clientul nu a fost gasit!";
                else
                {
                    int i = 0;
                    while (clienti[i].CNP != client_cautat.CNP)
                    {
                        i++;
                    }

                    if (txNume.Text != "")
                        clienti[i].Nume = txNume.Text;
                    if (txPrenume.Text != "")
                        clienti[i].Prenume = txPrenume.Text;
                    if (txCNP.Text != "")
                        clienti[i].CNP = txCNP.Text;

                    if (txNume.Text == "" && txPrenume.Text == "" && txCNP.Text == "")
                        lblMesaj3.Text = "Nu au fost date introduse!";
                    else
                    {
                        adminClienti.UpdateFisierClienti(clienti);
                        lblMesaj3.Text = "Modificare realizata cu succes!";
                    }
                }
            }
        }
    }
}
