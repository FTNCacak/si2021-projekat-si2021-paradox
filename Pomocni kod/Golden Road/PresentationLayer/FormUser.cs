using BusinessLayer;
using Shared.Models;
using System;
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
    public partial class FormUser : Form
    {
        readonly GoldenRoadBusiness goldenRoadBusiness = new GoldenRoadBusiness();

        public FormUser()
        {
            InitializeComponent();
        }

        public static class Global
        {
            public static string UserID;
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


        private void buttonUserLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUserId.Text == "" ||
                textBoxUserPassword.Text == "")
            {
                MessageBox.Show("Popunite sva tražena polja!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUserId.Focus();
                return;
            }

            Global.UserID = textBoxUserId.Text;


            foreach (User user in goldenRoadBusiness.GetAllUsers())
            {
                if (user.Korisnicki_Id == textBoxUserId.Text && user.Lozinka == textBoxUserPassword.Text)
                {
                    FormGoldenRoad.fGRinstance.btnLogin.Visible = false;
                    FormGoldenRoad.fGRinstance.btnRegister.Visible = false;
                    FormGoldenRoad.fGRinstance.btnLogout.Visible = true;
                    FormGoldenRoad.fGRinstance.btnPayment.Visible = true;
                    openChildForm(new FormYHSLI());
                    return;
                }
            }


            MessageBox.Show("Uneti podaci ne odgovaraju ni jednom korisniku!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;


    }
    }


}
