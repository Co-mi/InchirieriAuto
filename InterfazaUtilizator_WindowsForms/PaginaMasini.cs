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
    public partial class PaginaMasini : UserControl
    {
        OptiuniMasina optiuniSelectate = new OptiuniMasina();
        IStocareMasini adminMasini = StocareFactory.GetAdministratorStocareMasini();
        List<Masina> masini;

        public PaginaMasini()
        {
            InitializeComponent();
            masini = adminMasini.GetMasini();
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            ModelMasina? modelSelectat = GetModelSelectat();
            //set optiuni
            lblMesaj.ForeColor = Color.Red;
            if (txtSerieMasina.Text == "" || txtPretMasina.Text == "")
                lblMesaj.Text = "*completati toate \ncampurile!";
            else
            {
                lblMesaj.ForeColor = Color.Green;
                lblMesaj.Text = "Adaugare realizata\ncu succes!";
                string infoMasina = (int)modelSelectat + "," + txtSerieMasina.Text.ToUpper() + "," + txtPretMasina.Text + "," + (int)optiuniSelectate;
                masini.Add(new Masina(infoMasina));
                adminMasini.AddMasina(new Masina(infoMasina));
            }
        }

        private ModelMasina? GetModelSelectat()
        {
            if (rdbOpel.Checked)
                return ModelMasina.Opel;
            if (rdbRenault.Checked)
                return ModelMasina.Renault;
            if (rdbBMW.Checked)
                return ModelMasina.BMW;
            if (rdbAudi.Checked)
                return ModelMasina.Audi;
            if (rdbDacia.Checked)
                return ModelMasina.Dacia;
            if (rdbFord.Checked)
                return ModelMasina.Ford;
            if (rdbVolkswagen.Checked)
                return ModelMasina.Volkswagen;
            if (rdbMercedes.Checked)
                return ModelMasina.Mercedes;
            if (rdbTesla.Checked)
                return ModelMasina.Tesla;

            return null;
        }

        private void ckbDiscipline_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBoxControl = sender as CheckBox; //operator 'as'
                                                           //sau
                                                           //CheckBox checkBoxControl = (CheckBox)sender; //operator cast

            int optiuneSelectata = (int)Enum.Parse(typeof(OptiuniMasina), checkBoxControl.Text);
            //verificare daca checkbox-ul asupra caruia s-a actionat este selectat
            if (checkBoxControl.Checked == true)
                optiuniSelectate = (OptiuniMasina)((int)optiuniSelectate + optiuneSelectata);
            else
                optiuniSelectate = (OptiuniMasina)((int)optiuniSelectate - optiuneSelectata);
        }
        private void btnAfisare_Click(object sender, EventArgs e)
        {
            ResetareMesaje();
            lsbAfisareMasini.Items.Clear();
            string antetTabel = String.Format("{0,-13}{1,-20}{2,5}  {3,-30}\n", "Model", "Serie sasiu", "Pret", "Facilitati");
            lsbAfisareMasini.Items.Add(antetTabel);

            foreach (Masina _masina in masini)
            {
                //var linieTabel = String.Format("{0,-13}{1,-20}{2,5}   {3,-30}\n", _masina.Model, _masina.Serie.ToUpper(), _masina.Pret.ToString(),_masina.Optiuni.ToString());
                lsbAfisareMasini.Items.Add(_masina.ConversieLaSir());
            }
        }


        private void btnCautare_Click(object sender, EventArgs e)
        {
            ResetareMesaje();
            Masina masina_cautata;
            lblMesaj2.ForeColor = Color.Red;
            if (txtCautareSerieMasina.Text == "")
            {
                lblMesaj2.ForeColor = Color.Red;
                lblMesaj2.Text = "*completati toate campurile!";
            }
            else
            {

                masina_cautata = adminMasini.GetMasina( txtCautareSerieMasina.Text.ToUpper());
                if (masina_cautata == null)
                {
                    lblMesaj2.ForeColor = Color.White;
                    lblMesaj2.Text = "Masina nu a fost gasita!";
                }
                else
                {
                    lsbAfisareMasini.Items.Clear();
                    lblMesaj2.ForeColor = Color.Green;
                    lblMesaj2.Text = "Masina a fost gasita!";
                    string antetTabel = String.Format("{0,-13}{1,-20}{2,5}  {3,-30}\n", "Model", "Serie sasiu", "Pret", "Facilitati");
                    lsbAfisareMasini.Items.Add(antetTabel);
                    lsbAfisareMasini.Items.Add(masina_cautata.ConversieLaSir());
                }
            }
        }

        private void btnModificare_Click(object sender, EventArgs e)
        {
            ResetareMesaje();
            Masina masina_cautata;
            lblMesaj2.ForeColor = Color.Red;
            if (txtCautareSerieMasina.Text == "")
            {
                lblMesaj2.ForeColor = Color.Red;
                lblMesaj2.Text = "*completati toate campurile!";
            }
            else
            {
                masina_cautata = adminMasini.GetMasina(txtCautareSerieMasina.Text.ToUpper());
                if (masina_cautata == null)
                {
                    lblMesaj2.ForeColor = Color.White;
                    lblMesaj2.Text = "Masina nu a fost gasita!";
                }
                else
                {
                    int i = 0;
                    while (masini[i].Serie != masina_cautata.Serie)
                    {
                        i++;
                    }
                    ModelMasina? modelSelectat = GetModelSelectat();
                    masini[i].Model = (ModelMasina)modelSelectat;

                    if (txtSerieMasina.Text.ToUpper() != "")
                        masini[i].Serie = txtSerieMasina.Text.ToUpper();
                    if (txtPretMasina.Text != "")
                        masini[i].Pret = Convert.ToInt32(txtPretMasina.Text);


                    masini[i].Optiuni = optiuniSelectate;

                    //if (txtSerieMasina.Text.ToUpper() == "" && txtPretMasina.Text == "")
                    //{
                    //    lblMesaj2.Text = "Modificare esuata!";
                    //}
                    //else
                    {
                        adminMasini.UpdateFisierMasini(masini);
                        lblMesaj2.ForeColor = Color.Green;
                        lblMesaj2.Text = "Modificare realizata cu succes!";
                    }
                }
            }
        }
        

        public void ResetareMesaje()
        {
            lblMesaj.Text = lblMesaj2.Text  = string.Empty;
        }
    }
}
