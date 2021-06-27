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
    public partial class frmActiviteConsultation : Form
    {
        public frmActiviteConsultation()
        {
            InitializeComponent();
            rafraichirList();
        }

        void rafraichirList()
        {
            lvwActivite.Items.Clear();
            DataTable dt = Activite.SelectAll(txtCritere.Text);
            foreach (DataRow Row in dt.Rows)
            {
                string vCode = "";
                string vAgenCode = "";
                DateTime vDate = DateTime.Parse("01/01/2000");
                int vRecette = 0;
                int vDepense = 0;


                if (!DBNull.Value.Equals(Row["ActiCode"])) vCode = (string)Row["ActiCode"];
                if (!DBNull.Value.Equals(Row["AgenCode"])) vAgenCode = (string)Row["AgenCode"];
                if (!DBNull.Value.Equals(Row["ActiDate"])) vDate = (DateTime)Row["ActiDate"];
                if (!DBNull.Value.Equals(Row["ActiRecette"])) vRecette = (int)Row["ActiRecette"];
                if (!DBNull.Value.Equals(Row["ActiDepense"])) vDepense = (int)Row["ActiDepense"];

                ListViewItem itm = lvwActivite.Items.Add(vCode.ToString());
                itm.SubItems.Add(vAgenCode.ToString());
                itm.SubItems.Add(vDate.ToString());
                itm.SubItems.Add(vRecette.ToString());
                itm.SubItems.Add(vDepense.ToString());
                itm.Tag = vCode;
            }
        }

        private void bntAjouter_Click(object sender, EventArgs e)
        {
            frmActiviteNouveau frm = new frmActiviteNouveau();
            frm.ShowDialog();
        }

        private void bntFermer3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void frmActiviteGestion_Load(object sender, EventArgs e)
        {

        }

        private void bntActualiser_Click(object sender, EventArgs e)
        {
            rafraichirList();
        }

        private void bntConsulter_Click(object sender, EventArgs e)
        {
            if (lvwActivite.SelectedItems.Count > 0)
            {
                string vid = (string)lvwActivite.SelectedItems[0].Tag;
                Activite leObjet = new Activite(vid);
                frmActiviteNouveau frm = new frmActiviteNouveau(leObjet, 'c');
                frm.ShowDialog();
                rafraichirList();
            }
        }

        private void bntModifier_Click(object sender, EventArgs e)
        {
            if (lvwActivite.SelectedItems.Count > 0)
            {
                string vid = (string)lvwActivite.SelectedItems[0].Tag;
                Activite leObjet = new Activite(vid);
                frmActiviteNouveau frm = new frmActiviteNouveau(leObjet, 'm');
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
