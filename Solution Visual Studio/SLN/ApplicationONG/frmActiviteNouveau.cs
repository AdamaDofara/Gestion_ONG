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
    public partial class frmActiviteNouveau : Form
    {
        char vAppel = 'n';
        string vTitre;
        Activite CurrentObjectActivite = null;

        public frmActiviteNouveau()
        {
            InitializeComponent();
            InitForm(vAppel);
            CurrentObjectActivite = new Activite(); 
        }
        public frmActiviteNouveau(Activite unActivite, char pAppel)
        {
            InitializeComponent();
            CurrentObjectActivite = unActivite;
            vAppel = pAppel;
            InitForm(vAppel);
            AfficherActivite();
        }
        private void InitForm(char pAppel)
        {

            switch (pAppel)
            {
                case 'n':
                    vTitre = " - Ajout d'une Nouvelle Activité";
                    break;
                case 'c':
                    vTitre = " - Consultation d'une Activité";
                    btnenregistrer.Enabled = false;
                    txtacticode.Enabled = false;
                    txtagencode.Enabled = false;
                    txtactidate.Enabled = false;
                    txtactirecette.Enabled = false;
                    txtactidepense.Enabled = false;
                    break;
                case 'm':
                    txtacticode.Enabled = false;
                    vTitre = " - Modification d'une Activité";
                    txtacticode.ReadOnly = true;
                    btnenregistrer.Text = "&Modifier";
                    break;
                case 's':
                    txtacticode.Enabled = false;
                    vTitre = " - Suppression d'un Enrégistrement d'Activité";
                    btnenregistrer.Text = "&Supprimer";
                    break;
            }
            this.Text = Application.ProductName + vTitre;
        }
        public void AfficherActivite()
        {
            txtacticode.Text = CurrentObjectActivite.acticode;
            txtagencode.Text = CurrentObjectActivite.agencode;
            txtactidate.Text = Convert.ToString(CurrentObjectActivite.actidate);
            txtactirecette.Text = Convert.ToString(CurrentObjectActivite.actirecette);
            txtactidepense.Text = Convert.ToString(CurrentObjectActivite.actidepense);
    
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtLocalise_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntFermer2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmActiviteModification_Load(object sender, EventArgs e)
        {

        }
        private Boolean OkSaisie()
        {
            if (string.IsNullOrEmpty(txtacticode.Text))
            {
                MessageBox.Show("Veuillez saisir le code de l'activite", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtacticode.Focus();
                return false;
            }
            return true;
        }
        private void mapFormToObject()
        {
            CurrentObjectActivite.acticode = txtacticode.Text;
            CurrentObjectActivite.agencode = txtagencode.Text;
            CurrentObjectActivite.actidate = DateTime.Parse(txtactidate.Text);
            CurrentObjectActivite.actirecette = int.Parse(txtactirecette.Text);
            CurrentObjectActivite.actidepense = int.Parse(txtactidepense.Text);
        }

        private void btnenregistrer_Click(object sender, EventArgs e)
        {
            if (OkSaisie())
            {
                mapFormToObject();
                switch (vAppel)
                {
                    case 'n':
                        if (!DiversActivite.ExisteActivite(txtacticode.Text))
                        {
                            CurrentObjectActivite.Insert();
                            MessageBox.Show("L'enregistrement a été ajouté", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Risque de doublon, l'enregistrement a été ignoré", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        break;

                    case 'm':
                        if (DiversActivite.ExisteActivite(txtacticode.Text))
                        {
                            CurrentObjectActivite.Update();
                            MessageBox.Show("L'enregistrement a été modifié", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Cet ActiviteClient n'existe pas; modification impossible ", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
