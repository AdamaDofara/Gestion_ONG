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
    public partial class frmDemarrage : Form
    {
        public frmDemarrage()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (txtUserLogin.Text != "" && txtMotPass.Text != "")
            {
                btnConnexion.Enabled = true;
            }
            else
            {
                btnConnexion.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtUserLogin.Text != "")
            {
                if (txtMotPass.Text != "")
                {
                    frmMenuPrincipal frm = new frmMenuPrincipal();
                    frm.ShowDialog();
                }
                else MessageBox.Show("Mot de passe Incorrect");
            }
            else MessageBox.Show("Login name incorrect");
        }


        private void frmDemarrage_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Add("Personnel");
            comboBox2.Items.Add("Administration");
            comboBox2.SelectedItem = "Personnel";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtUserLogin_TextChanged(object sender, EventArgs e)
        {
            if (txtUserLogin.Text != "" && txtMotPass.Text != "")
            {
                btnConnexion.Enabled = true;
            }
            else
            {
                btnConnexion.Enabled = false;
            }
        }
        private void txtUserLogin_Enter(object sender, EventArgs e)
        {
            txtUserLogin.BackColor = Color.Beige;
        }
        private void txtUserLogin_Leave(object sender, EventArgs e)
        {
            txtUserLogin.BackColor = Color.White;
        }

        private void txtMotPass_Leave(object sender, EventArgs e)
        {
            txtMotPass.BackColor = Color.White;
        }

        private void txtMotPass_Enter(object sender, EventArgs e)
        {
            txtMotPass.BackColor = Color.Beige;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
