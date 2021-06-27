using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationONG
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void frmMenuPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fichierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Disponible sur la prochaine version", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void quitterToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void gestionDeCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmResponsableConsultation frm = new frmResponsableConsultation();
            frm.ShowDialog();
        }

        private void gestionDeDépotClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgenceConsultation frm = new frmAgenceConsultation();
            frm.ShowDialog();
        }

        private void gestionDeCamionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmActiviteConsultation frm = new frmActiviteConsultation();
            frm.ShowDialog();
        }

        private void etatDesClientsEnPorrtefeuilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmActiviteNouveau frm = new frmActiviteNouveau();
            frm.ShowDialog();
        }

        private void quitterToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void motDePasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Disponible sur la prochaine version", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void produitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Disponible sur la prochaine version", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void enrégistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enrégistrement effectué avec succès !", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("KLOUN-OUFFOUET” est une organisation non gouvernementale (ONG) qui est implantée dans plusieurs villes de la zone UEMOA. Son siège est à Paris", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void agencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("KLOUN-OUFFOUET” est une organisation non gouvernementale (ONG) qui est implantée dans plusieurs villes de la zone UEMOA. Son siège est à Paris", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void siègeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Disponible sur la prochaine version", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void adminiistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("KLOUN-OUFFOUET” est une organisation non gouvernementale (ONG) qui est implantée dans plusieurs villes de la zone UEMOA. Son siège est à Paris", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void organisationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("KLOUN-OUFFOUET” est une organisation non gouvernementale (ONG) qui est implantée dans plusieurs villes de la zone UEMOA. Son siège est à Paris", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void commandeEnAttenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgenceNouveau frm = new frmAgenceNouveau();
            frm.ShowDialog();
        }

        private void commandeDunePériodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmResponsableNouveau frm = new frmResponsableNouveau();
            frm.ShowDialog();
        }

        private void gestionDeProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAppreciationConsultation frm = new frmAppreciationConsultation();
            frm.ShowDialog();
        }

        private void aProposDeLapplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("www.SoftInt.com/contacts", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dépotClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Disponible sur la prochaine version", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information); ;
        }

        private void commandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Disponible sur la prochaine version", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gestionDesEmployeéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Disponible sur la prochaine version", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gestionDuBudgetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Disponible sur la prochaine version", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gestionRepresentativeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Disponible sur la prochaine version", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gestionDuPersonnelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Disponible sur la prochaine version", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information); ;
        }

        private void gestionDuBudgetToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Disponible sur la prochaine version", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gestionRepresentativeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Disponible sur la prochaine version", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void aProposDesDeveloppeursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chef Programmeur : DIEI Salomon", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void obtenirDeLaideEnLigneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ecrivez à www.SoftInt.com", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void contacterLesDeveloppeursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WWW.SoftInt.com/contacts", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void appréciationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAppreciationNouveau frm = new frmAppreciationNouveau();
            frm.ShowDialog();
        }
    }
}
