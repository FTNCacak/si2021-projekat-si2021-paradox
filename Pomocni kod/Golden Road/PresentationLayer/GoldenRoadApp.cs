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
        public static FormGoldenRoad fGRinstance;
        public Button btnLogout, btnCheck, btnPayment, btnLogin, btnRegister;
        public Panel pnlChildForm;
        public FormGoldenRoad()
        {
            InitializeComponent();
            fGRinstance = this;
            btnLogout = buttonLogout;
            btnCheck = buttonFormCheck;
            btnPayment = buttonFormPayment;
            btnLogin = buttonLogin;
            btnRegister = buttonRegister;
            pnlChildForm = panelChildForm;
            customizeDesing();
            openChildForm(new FormWelcome());
            //Code...
        }

        private void customizeDesing()
        {
            buttonLogin.Visible = true;
            buttonRegister.Visible = true;
            panelPopUp.Visible = false;
            buttonFormCheck.Visible = false;
            buttonFormPayment.Visible = false;
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
        public Form activeForm = null;
        public void openChildForm(Form childForm)
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
            hidePopUpMenu();
            openChildForm(new FormRegister());
        }

        private void buttonFormCheck_Click(object sender, EventArgs e)
        {
            hidePopUpMenu();
            openChildForm(new FormCheck());
        }

        private void buttonFormPayment_Click(object sender, EventArgs e)
        {
            hidePopUpMenu();
            openChildForm(new FormPayment());
        }

        public void buttonLogout_Click(object sender, EventArgs e)
        {
            customizeDesing();
            openChildForm(new FormWelcome());

        }
        //Side menu end
    }
}
