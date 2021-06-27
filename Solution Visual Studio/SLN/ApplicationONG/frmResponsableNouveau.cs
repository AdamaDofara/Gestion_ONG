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
    public partial class frmResponsableNouveau : Form
    {
        char vAppel = 'n';
        string vTitre;
        Responsable CurrentObjectResponsable = null;
        public frmResponsableNouveau()
        {
            InitializeComponent();
            InitForm(vAppel);
            CurrentObjectResponsable = new Responsable();
        }

        public frmResponsableNouveau(Responsable unResponsable, char pAppel)
        {
            InitializeComponent();
            CurrentObjectResponsable = unResponsable;
            vAppel = pAppel;
            InitForm(vAppel);
            AfficherResponsable();
        }
        private void InitForm(char pAppel)
        {

            switch (pAppel)
            {
                case 'n':
                    vTitre = " - Ajout d'un Nouvel Enrégistrement de responsable";
                    break;
                case 'c':
                    textrespocode.Enabled = false;
                    txtresponom.Enabled = false;
                    txtrespoprenom.Enabled = false;
                    vTitre = " - Consultation d'un Enrégistrement de responsable";
                    btnenregistrer.Enabled = false;
                    break;
                case 'm':
                    textrespocode.Enabled = false;
                    vTitre = " - Modification d'un Enrégistrement de responsable ";
                    textrespocode.ReadOnly = true;
                    btnenregistrer.Text = "&Modifier";
                    break;
                case 's':
                    textrespocode.Enabled = false;
                    vTitre = " - Suppression d'un Enrégistrement de responsable";
                    btnenregistrer.Text = "&Supprimer";
                    break;
            }
            this.Text = Application.ProductName + vTitre;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void bntFermer2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmResponsableModification_Load(object sender, EventArgs e)
        {

        }
        public void AfficherResponsable()
        {
            textrespocode.Text = CurrentObjectResponsable.respocode;
            txtresponom.Text = CurrentObjectResponsable.responom;
            txtrespoprenom.Text = CurrentObjectResponsable.respoprenom;

        }

        private Boolean OkSaisie()
        {
            if (string.IsNullOrEmpty(textrespocode.Text))
            {
                MessageBox.Show("Veuillez saisir le code du responsable", Application.ProductName,MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textrespocode.Focus();
                return false;
            }
            return true;
        }
        private void mapFormToObject()
        {
            CurrentObjectResponsable.respocode = textrespocode.Text;
            CurrentObjectResponsable.responom = txtresponom.Text;
            CurrentObjectResponsable.respoprenom = txtrespoprenom.Text;
        }
        private void bntEnregistrer_Click(object sender, EventArgs e)
        {
            if (OkSaisie())
            {
                mapFormToObject();
                switch (vAppel)
                {
                    case 'n':
                        if (!Divers.ExisteResponsable(textrespocode.Text))
                        {
                            CurrentObjectResponsable.Insert();
                            MessageBox.Show("L'enregistrement a été ajouté", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Risque de doublon, l'enregistrement a été ignoré", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        break;

                    case 'm':
                        if (Divers.ExisteResponsable(textrespocode.Text))
                        {
                            CurrentObjectResponsable.Update();
                            MessageBox.Show("L'enregistrement a été modifié", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Cet Responsable n'existe pas; modification impossible ", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
