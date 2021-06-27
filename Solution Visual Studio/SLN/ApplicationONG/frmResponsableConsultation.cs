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
    public partial class frmResponsableConsultation : Form
    {
        public frmResponsableConsultation()
        {
            InitializeComponent();
            rafraichirList();
        }
        void rafraichirList()
        {
            lvwResponsable.Items.Clear();
            DataTable dt = Responsable.SelectAll(txtCritere.Text);

            foreach (DataRow Row in dt.Rows)
            {
                string vCode = "";
                string vNom = "";
                string vPrenom = "";


                if (!DBNull.Value.Equals(Row["RespoCode"])) vCode = (string)Row["RespoCode"];
                if (!DBNull.Value.Equals(Row["RespoNom"])) vNom = (string)Row["RespoNom"];
                if (!DBNull.Value.Equals(Row["RespoPrenom"])) vPrenom = (string)Row["RespoPrenom"];

                ListViewItem itm = lvwResponsable.Items.Add(vCode.ToString());
                itm.SubItems.Add(vNom.ToString());
                itm.SubItems.Add(vPrenom.ToString());
                itm.Tag = vCode;
            }
        }


        private void bntAjouter_Click(object sender, EventArgs e)
        {
            frmResponsableNouveau frm = new frmResponsableNouveau();
            frm.ShowDialog();
        }

        private void bntFermer3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmResponsableGestion_Load(object sender, EventArgs e)
        {
            
        }

        private void bntActualiser_Click(object sender, EventArgs e)
        {
            rafraichirList();
        }

        private void lvwResponsable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCritere_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntConsulter_Click(object sender, EventArgs e)
        {
            if (lvwResponsable.SelectedItems.Count > 0)
            {
                string vid = (string)lvwResponsable.SelectedItems[0].Tag;
                Responsable leObjet = new Responsable(vid);
                frmResponsableNouveau frm = new frmResponsableNouveau(leObjet, 'c');
                frm.ShowDialog();
                rafraichirList();
            }
        }

        private void bntModifier_Click(object sender, EventArgs e)
        {
            if (lvwResponsable.SelectedItems.Count > 0)
            {
                string vid = (string)lvwResponsable.SelectedItems[0].Tag;
                Responsable leObjet = new Responsable(vid);
                frmResponsableNouveau frm = new frmResponsableNouveau(leObjet, 'm');
                frm.ShowDialog();
                rafraichirList();
            }
        }

        private void bntSupprimer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cet enregistrement a été supprimé !", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
