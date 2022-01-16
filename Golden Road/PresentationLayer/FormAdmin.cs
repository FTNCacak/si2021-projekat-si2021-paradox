using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        static class Constants
        {
            public const long a = 19062000;
            public const long m = 27022001;
            public const long s = 27032000;
            public const long p = 21071999;
        }

        public Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            FormGoldenRoad.fGRinstance.pnlChildForm.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonAdminLogin_Click(object sender, EventArgs e)
        {
            if(textBoxAdminPassword.Text == "")
            {
                MessageBox.Show("Niste uneli lozinku!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAdminPassword.Focus();
                return;
            }

            if (long.Parse(textBoxAdminPassword.Text) == Constants.a ||
                long.Parse(textBoxAdminPassword.Text) == Constants.m ||
                long.Parse(textBoxAdminPassword.Text) == Constants.s ||
                long.Parse(textBoxAdminPassword.Text) == Constants.p
                )
            {
                FormGoldenRoad.fGRinstance.btnLogin.Visible = false;
                FormGoldenRoad.fGRinstance.btnRegister.Visible = false;
                FormGoldenRoad.fGRinstance.btnLogout.Visible = true;
                FormGoldenRoad.fGRinstance.btnCheck.Visible = true;
                openChildForm(new FormYHSLI());
            }

            else
            {
                MessageBox.Show("Admin sa ovom šifrom ne postoji u bazi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAdminPassword.Focus();
                return;
            }

        }
    }
}
