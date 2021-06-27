using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MetierONG;
namespace ApplicationONG
{
    public partial class frmAppreciationNouveau : Form
    {
        char vAppel = 'n';
        string vTitre;
        Appreciation CurrentObjectAppreciation = null;
        public frmAppreciationNouveau()
        {
            InitializeComponent();
            InitForm(vAppel);
            CurrentObjectAppreciation = new Appreciation();
        }

        private void bntFermer2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAppreciationModification_Load(object sender, EventArgs e)
        {

        }
        public frmAppreciationNouveau(Appreciation unAppreciation, char pAppel)
        {
            InitializeComponent();
            CurrentObjectAppreciation = unAppreciation;
            vAppel = pAppel;
            InitForm(vAppel);
            AfficherAppreciation();
        }
        private void InitForm(char pAppel)
        {

            switch (pAppel)
            {
                case 'n':
                    vTitre = " - Ajout d'une Nouvelle Appreciation";
                    break;
                case 'c':
                    vTitre = " - Consultation d'une Appreciation";
                    textRespoCode.Enabled = false;
                    txtActicode.Enabled = false;
                    txtAppreciation.Enabled = false;
                    txtJustifRecette.Enabled = false;
                    txtjustifDepense.Enabled = false;
                    bntEnregistrer.Enabled = false;
                    break;
                case 'm':
                    textRespoCode.Enabled = false;
                    vTitre = " - Modification d'une Appreciation";
                    textRespoCode.ReadOnly = true;
                    txtActicode.ReadOnly = true;
                    bntEnregistrer.Text = "&Modifier";
                    break;
                case 's':
                    textRespoCode.Enabled = false;
                    vTitre = " - Suppression d'un Enrégistrement d'Appreciation";
                    bntEnregistrer.Text = "&Supprimer";
                    break;
            }
            this.Text = Application.ProductName + vTitre;
        }
        public void AfficherAppreciation()
        {
            textRespoCode.Text = CurrentObjectAppreciation.respocode;
            txtActicode.Text = CurrentObjectAppreciation.acticode;
            txtAppreciation.Text = CurrentObjectAppreciation.appreciationactivite;
            txtJustifRecette.Text = CurrentObjectAppreciation.justifrecette;
            txtjustifDepense.Text = CurrentObjectAppreciation.justifdepense;
        }
        private Boolean OkSaisie()
        {
            if (string.IsNullOrEmpty(textRespoCode.Text))
            {
                MessageBox.Show("Veuillez saisir le code de l'activté", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtActicode.Focus();
                return false;
            }
            return true;
        }
        private void mapFormToObject()
        {
            CurrentObjectAppreciation.respocode = textRespoCode.Text;
            CurrentObjectAppreciation.acticode = txtActicode.Text;
            CurrentObjectAppreciation.appreciationactivite = txtAppreciation.Text;
            CurrentObjectAppreciation.justifrecette = txtJustifRecette.Text;
            CurrentObjectAppreciation.justifdepense = txtjustifDepense.Text;
        }

        private void bntEnregistrer_Click(object sender, EventArgs e)
        {
            if (OkSaisie())
            {
                mapFormToObject();
                switch (vAppel)
                {
                    case 'n':
                        if (DiverAppreciation.ExisteAppreciation(txtActicode.Text))
                        {
                            CurrentObjectAppreciation.Insert();
                            MessageBox.Show("L'enregistrement a été ajouté", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Risque de doublon, l'enregistrement a été ignoré", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        break;

                    case 'm':
                        if (DiverAppreciation.ExisteAppreciation(txtActicode.Text))
                        {
                            CurrentObjectAppreciation.Update();
                            MessageBox.Show("L'enregistrement a été modifié", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Cet Appreciation n'existe pas; modification impossible ", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        break;

                    case 'c':

                        break;

                    case 's':

                        break;
                }
            }
        }
    }
}
