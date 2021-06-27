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
    public partial class frmAppreciationConsultation : Form
    {
        public frmAppreciationConsultation()
        {
            InitializeComponent();
            rafraichirList();
        }
        void rafraichirList()
        {
            lvwAppreciation.Items.Clear();
            DataTable dt = Appreciation.SelectAll(txtCritere.Text);
            foreach (DataRow Row in dt.Rows)
            {
                string vCode = "";
                string vactiCode = "";
                string vAppreciation = "";
                string vRecette = "";
                string vDepense = "";


                if (!DBNull.Value.Equals(Row["RespoCode"])) vCode = (string)Row["RespoCode"];
                if (!DBNull.Value.Equals(Row["ActiCode"])) vactiCode = (string)Row["ActiCode"];
                if (!DBNull.Value.Equals(Row["AppreciationActivite"])) vAppreciation = (string)Row["AppreciationActivite"];
                if (!DBNull.Value.Equals(Row["JustifRecette"])) vRecette = (string)Row["JustifRecette"];
                if (!DBNull.Value.Equals(Row["JustifDepense"])) vDepense = (string)Row["JustifDepense"];

                ListViewItem itm = lvwAppreciation.Items.Add(vCode.ToString());
                itm.SubItems.Add(vactiCode.ToString());
                itm.SubItems.Add(vAppreciation.ToString());
                itm.SubItems.Add(vRecette.ToString());
                itm.SubItems.Add(vDepense.ToString());
                itm.Tag = vCode;
            }
        }

        private void frmAppreciationConsulation_Load(object sender, EventArgs e)
        {

        }

        private void bntAjouter_Click(object sender, EventArgs e)
        {
            frmAppreciationNouveau frm = new frmAppreciationNouveau();
            frm.ShowDialog();
        }

        private void bntFermer3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntActualiser_Click(object sender, EventArgs e)
        {
            rafraichirList();
        }

        private void bntModifier_Click(object sender, EventArgs e)
        {
            if (lvwAppreciation.SelectedItems.Count > 0)
            {
                string vid = (string)lvwAppreciation.SelectedItems[0].Tag;
                Appreciation leObjet = new Appreciation(vid);
                frmAppreciationNouveau frm = new frmAppreciationNouveau(leObjet, 'm');
                frm.ShowDialog();
                rafraichirList();
            }
        }

        private void bntConsulter_Click(object sender, EventArgs e)
        {
            if (lvwAppreciation.SelectedItems.Count > 0)
            {
                string vid = (string)lvwAppreciation.SelectedItems[0].Tag;
                Appreciation leObjet = new Appreciation(vid);
                frmAppreciationNouveau frm = new frmAppreciationNouveau(leObjet, 'c');
                frm.ShowDialog();
                rafraichirList();
            }
        }

        private void bntSupprimer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cet enregistrement a été supprimé !", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lvwAppreciation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


