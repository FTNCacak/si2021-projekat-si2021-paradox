using BusinessLayer;
using System;
using Shared.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FormRegister : Form
    {
        readonly GoldenRoadBusiness goldenRoadBusiness = new GoldenRoadBusiness();
        public FormRegister()
        {
            InitializeComponent();
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

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text == "" ||
                textBoxLastName.Text == "" ||
                textBoxUserId.Text == "" ||
                textBoxPassword.Text == "" ||
                textBoxJmbg.Text == "" ||
                textBoxEmail.Text == "")
            {
                MessageBox.Show("Popunite sva tražena polja!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFirstName.Focus();
                return;
            }


            if (!Regex.Match(textBoxFirstName.Text, "^[A-Z][a-z]*$").Success)
            {
                MessageBox.Show("Ime nije pravilno uneto!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFirstName.Focus();
                return;
            }

            if (!Regex.Match(textBoxLastName.Text, "^[A-Z][a-z]*$").Success)
            {
                MessageBox.Show("Prezime nije pravilno uneto!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxLastName.Focus();
                return;
            }

            if (!Regex.Match(textBoxUserId.Text, "^[a-zA-Z][a-zA-Z0-9]{8,20}").Success)
            {
                MessageBox.Show("Korisničko ime nije pravilno uneto! Dužina korisničkog imena mora biti između 8 i 20 karaktera!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUserId.Focus();
                return;
            }

            if (!Regex.Match(textBoxPassword.Text, "^[a-zA-Z][a-zA-Z0-9]{10,20}").Success)
            {
                MessageBox.Show("Lozinka nije pravilno uneta! Dužina lozinke mora biti između 10 i 20 karaktera!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPassword.Focus();
                return;
            }

            if (!Regex.Match(textBoxJmbg.Text, "^[0-9]{13}").Success)
            {
                MessageBox.Show("JMBG mora sadržati 13 cifara!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxJmbg.Focus();
                return;
            }

            /*regex za email neće postojati, proverava se kroz unit, 
            suviše kompleksan izraz za testiranje bi
            trebao da bude kako bi se pokrila svaka greška*/

           if (!Regex.Match(textBoxPhone.Text, @"^([0][6]\d{1}[0-9]\d{2,3}\d{3,4}$)?").Success)
            {
                MessageBox.Show("Broj telefona nije pravilno unet!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPhone.Focus();
                return;
            }

            if (!Regex.Match(textBoxAddress.Text, @"^(([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z])+\s[0-9]+$)?").Success)
            {
                MessageBox.Show("Adresa nije pravilno uneta!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAddress.Focus();
                return;
            }

            User user = new User(textBoxFirstName.Text,textBoxLastName.Text, textBoxUserId.Text, textBoxPassword.Text, textBoxJmbg.Text, textBoxEmail.Text, textBoxPhone.Text, textBoxAddress.Text);
            goldenRoadBusiness.InsertUser(user);

            FormGoldenRoad.fGRinstance.btnLogin.Visible = false;
            FormGoldenRoad.fGRinstance.btnRegister.Visible = false;
            FormGoldenRoad.fGRinstance.btnLogout.Visible = true;
            FormGoldenRoad.fGRinstance.btnPayment.Visible = true;
            openChildForm(new FormYHSR());
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {
        
        }
    }
}
