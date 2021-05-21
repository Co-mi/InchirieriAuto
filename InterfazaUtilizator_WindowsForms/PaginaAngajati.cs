using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrarieModele;
using NivelAccesDate;

namespace InterfazaUtilizator_WindowsForms
{
    public partial class PaginaAngajati : UserControl
    {
        IStocareAngajati adminAngajati = StocareFactory.GetAdministratorStocareAngajati();
        List<Angajat> angajati;
        public PaginaAngajati()
        {
            InitializeComponent();
            angajati = adminAngajati.GetAngajati();
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            ResetareMesaje();
            string numeComplet;
            if (txtNumeAngajat.Text == "" || txtPrenumeAngajat.Text == "" || txtCNPAngajat.Text == "" || txtFunctieAngajat.Text == "")
            {
                lblMesaj.ForeColor = Color.Red;
                lblMesaj.Text = "*completati toate campurile!";
            }
            else
            {
                numeComplet = txtNumeAngajat.Text + "," + txtPrenumeAngajat.Text + "," + txtCNPAngajat.Text + "," + txtFunctieAngajat.Text;
                Angajat _angajat = new Angajat(numeComplet);
                lblMesaj.ForeColor = Color.Green;
                lblMesaj.Text = "Adaugare realizata cu succes!";
                angajati.Add(_angajat);
                //Adaugare client in fisier
                adminAngajati.AddAngajat(_angajat);
            }
        }

        private void btnAfisare_Click(object sender, EventArgs e)
        {
            ResetareMesaje();
            rtbAfiseazaAngajati.Clear();
            //parcurgere colectie de obiecte 'Clienti'
            foreach (Angajat a in angajati)
            {
                rtbAfiseazaAngajati.AppendText(a.ConversieLaSir() + "\n");
                rtbAfiseazaAngajati.AppendText(Environment.NewLine);
            }
        }

        private void btnCautare_Click(object sender, EventArgs e)
        {
            ResetareMesaje();
            Angajat angajat_cautat;
            if (txtCautareNumeAngajat.Text == "" || txtCautarePrenumeAngajat.Text == "")
            {
                lblMesaj2.ForeColor = Color.Red;
                lblMesaj2.Text = "*completati toate campurile!";
            }
            else
            {
                angajat_cautat = adminAngajati.GetAngajat(txtCautareNumeAngajat.Text, txtCautarePrenumeAngajat.Text);
                if (angajat_cautat == null)
                {
                    lblMesaj2.ForeColor = Color.White;
                    lblMesaj2.Text = "Angajatul nu a fost gasit!";
                }
                else
                {
                    rtbAfiseazaAngajati.Clear();
                    lblMesaj2.ForeColor = Color.Green;
                    lblMesaj2.Text = "Angajatul a fost gasit!";
                    rtbAfiseazaAngajati.AppendText(angajat_cautat.ConversieLaSir());
                }
            }
        }

        private void btnModificare_Click(object sender, EventArgs e)
        {
            ResetareMesaje();
            Angajat angajat_cautat;
            if (txtCautareNumeAngajat.Text == "" || txtCautarePrenumeAngajat.Text == "")
            {
                lblMesaj2.ForeColor = Color.Red;
                lblMesaj2.Text = "*completati toate campurile!";
            }
            else
            {
                angajat_cautat = adminAngajati.GetAngajat(txtCautareNumeAngajat.Text, txtCautarePrenumeAngajat.Text);
                if (angajat_cautat == null)
                {
                    lblMesaj2.ForeColor = Color.White;
                    lblMesaj2.Text = "Angajatul nu a fost gasit!";
                }
                else
                {
                    int i = 0;
                    while (angajati[i].CNP != angajat_cautat.CNP)
                    {
                        i++;
                    }

                    if (txNume.Text != "")
                        angajati[i].Nume = txNume.Text;
                    if (txPrenume.Text != "")
                        angajati[i].Prenume = txPrenume.Text;
                    if (txCNP.Text != "")
                        angajati[i].CNP = txCNP.Text;

                    if (txNume.Text == "" && txPrenume.Text == "" && txCNP.Text == "")
                    {
                        lblMesaj3.ForeColor = Color.Red;
                        lblMesaj3.Text = "*nu au fost date introduse!";
                    }
                    else
                    {
                        adminAngajati.UpdateFisierAngajati(angajati);
                        lblMesaj3.ForeColor = Color.Green;
                        lblMesaj3.Text = "Modificare realizata cu succes!";
                    }
                }
            }
        }

        public void ResetareMesaje()
        {
            lblMesaj.Text = lblMesaj2.Text = lblMesaj3.Text = string.Empty;

        }
    }
}
