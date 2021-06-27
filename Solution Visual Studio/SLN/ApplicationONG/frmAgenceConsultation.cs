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
    public partial class frmAgenceConsultation : Form
    {
        public frmAgenceConsultation()
        {
            InitializeComponent();
            rafraichirList();
        }
        void rafraichirList()
        {
            lvwAgence.Items.Clear();
            DataTable dt = Agence.SelectAll(txtCritere.Text);
            foreach (DataRow Row in dt.Rows)
            {
                string vCode = "";
                string vRespoCode = "";
                string vVille = "";
                string vPays = "";
                string vContinent = "";


                if (!DBNull.Value.Equals(Row["AgenCode"])) vCode = (string)Row["AgenCode"];
                if (!DBNull.Value.Equals(Row["RespoCode"])) vRespoCode = (string)Row["RespoCode"];
                if (!DBNull.Value.Equals(Row["AgenVille"])) vVille = (string)Row["AgenVille"];
                if (!DBNull.Value.Equals(Row["AgenPays"])) vPays = (string)Row["AgenPays"];
                if (!DBNull.Value.Equals(Row["AgenContinent"])) vContinent = (string)Row["AgenContinent"];

                ListViewItem itm = lvwAgence.Items.Add(vCode.ToString());
                itm.SubItems.Add(vRespoCode.ToString());
                itm.SubItems.Add(vVille.ToString());
                itm.SubItems.Add(vPays.ToString());
                itm.SubItems.Add(vContinent.ToString());
                itm.Tag = vCode;
            }
        }

        private void lvwAgence_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bntFermer3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDepotClientChoix_Load(object sender, EventArgs e)
        {

        }

        private void bntAjouter_Click(object sender, EventArgs e)
        {
            frmAgenceNouveau frm = new frmAgenceNouveau();
            frm.ShowDialog();
        }

        private void bntConsulter_Click(object sender, EventArgs e)
        {
            if (lvwAgence.SelectedItems.Count > 0)
            {
                string vid = (string)lvwAgence.SelectedItems[0].Tag;
                Agence leObjet = new Agence(vid);
                frmAgenceNouveau frm = new frmAgenceNouveau(leObjet, 'c');
                frm.ShowDialog();
                rafraichirList();
            }
        }

        private void bntActualiser_Click(object sender, EventArgs e)
        {
            rafraichirList();
        }

        private void txtCritere_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntModifier_Click(object sender, EventArgs e)
        {
            if (lvwAgence.SelectedItems.Count > 0)
            {
                string vid = (string)lvwAgence.SelectedItems[0].Tag;
                Agence leObjet = new Agence(vid);
                frmAgenceNouveau frm = new frmAgenceNouveau(leObjet, 'm');
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