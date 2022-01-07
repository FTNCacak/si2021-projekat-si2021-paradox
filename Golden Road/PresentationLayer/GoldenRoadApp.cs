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
    public partial class FormGoldenRoad : Form
    {
        public FormGoldenRoad()
        {
            InitializeComponent();
            customizeDesing();
            //Code...
        }

        private void customizeDesing()
        {
            buttonLogin.Visible = true;
            buttonRegister.Visible = true;
            panelPopUp.Visible = false;
            buttonCheck.Visible = false;
            buttonPayment.Visible = false;
            buttonLogout.Visible = false;
        }
        
        private void hidePopUpMenu()
        {
            if (panelPopUp.Visible == true)
                panelPopUp.Visible = false;
        }
        
        private void showPopUpMenu(Panel popUpMenu)
        {
            if (popUpMenu.Visible == false)
            {
                popUpMenu.Visible = true;
            }
            else
                hidePopUpMenu();
        }

        //Pocetak metode za otvaranje drugih formi unutar panela panelChildForm
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }
        //Kraj metode

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Side menu start
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            showPopUpMenu(panelPopUp);
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            hidePopUpMenu();
            openChildForm(new FormAdmin());
        }

        private void buttonUser_Click_1(object sender, EventArgs e)
        {
            hidePopUpMenu();
            openChildForm(new FormUser());
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            //openChildForm(new FormRegister());
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            //openChildForm(FormCheck);
        }

        private void buttonPayment_Click(object sender, EventArgs e)
        {
            //openChildForm(FormPayment);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            customizeDesing();
        }
        //Side menu end
    }
}
