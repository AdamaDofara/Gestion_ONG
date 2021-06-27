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
    public partial class frmAgenceNouveau : Form
    {
        char vAppel = 'n';
        string vTitre = "";
        Agence CurrentObjectAgence = null;

        public frmAgenceNouveau()
        {
            InitializeComponent();
            InitForm(vAppel);
            CurrentObjectAgence = new Agence();
        }

        public frmAgenceNouveau(Agence unAgence, char pAppel)
        {
            InitializeComponent();
            CurrentObjectAgence = unAgence;
            vAppel = pAppel;
            InitForm(vAppel);
            AfficherAgence();
        }
        public void AfficherAgence()
        {
            txtagencode.Text = CurrentObjectAgence.agencode;
            txtrespocode.Text = CurrentObjectAgence.respocode;
            txtagenville.Text = CurrentObjectAgence.agenville;
            txtagenpays.Text = CurrentObjectAgence.agenpays;
            txtagencontinent.Text = CurrentObjectAgence.agencontinent;


        }
        private void mapFormToObject()
        {
            CurrentObjectAgence.agencode = txtagencode.Text;
            CurrentObjectAgence.respocode = txtrespocode.Text;
            CurrentObjectAgence.agenville = txtagenville.Text;
            CurrentObjectAgence.agenpays = txtagenpays.Text;
            CurrentObjectAgence.agencontinent = txtagencontinent.Text;
        }
        private void InitForm(char pAppel)
        {

            switch (pAppel)
            {
                case 'n':
                    vTitre = " - Ajout d'un Nouvel Enrégistrement d' Agence";
                    break;
                case 'c':
                    txtagencode.Enabled = false;
                    txtrespocode.Enabled = false;
                    txtagencontinent.Enabled = false;
                    txtagenville.Enabled = false;
                    txtagenpays.Enabled = false;
                    btnenregistrer.Enabled = false;
                    vTitre = " - Consultation d'un Enrégistrement d' Agence";

                    break;
                case 'm':
                    txtagencode.Enabled = false;
                    txtrespocode.Enabled = false;
                    vTitre = " - Modification d'un Enrégistrement d' Agence";
                    txtagencode.ReadOnly = true;
                    btnenregistrer.Text = "&Modifier";
                    break;
                case 's':
                    txtagencode.Enabled = false;
                    vTitre = " - Suppression d'un Enrégistrement d' Agence";
                    btnenregistrer.Text = "&Supprimer";
                    break;
            }
            this.Text = Application.ProductName + vTitre;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntFermer2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bntEnregistrer_Click(object sender, EventArgs e)
        {
            if (OkSaisie())
            {
                mapFormToObject();
                switch (vAppel)
                {
                    case 'n':
                        if (!DiversAgen.ExisteAgence(txtagencode.Text))
                        {
                            CurrentObjectAgence.Insert();
                            MessageBox.Show("L'enregistrement a été ajouté", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Risque de doublon, l'enregistrement a été ignoré", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        break;

                    case 'm':
                        if (DiversAgen.ExisteAgence(txtagencode.Text))
                        {
                            CurrentObjectAgence.Update();
                            MessageBox.Show("L'enregistrement a été modifié", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Cette agence n'existe pas; modification impossible ", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        break;

                    case 'c':

                        break;

                    case 's':

                        break;
                }
            }
        }

        private Boolean OkSaisie()
        {
            if (string.IsNullOrEmpty(txtagencode.Text))
            {
                MessageBox.Show("Veuillez saisir le code de l'agence", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtagencode.Focus();
                return false;
            }
            return true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtrespocode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtagenpays_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
