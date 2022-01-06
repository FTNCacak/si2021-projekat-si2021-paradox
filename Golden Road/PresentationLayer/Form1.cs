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
            panelPopUp.Visible = false;
            buttonCheck.Enabled = false;
            buttonPayment.Enabled = false;
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            showPopUpMenu(panelPopUp);
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            hidePopUpMenu();
            //Code...
        }

        private void buttonUser_Click_1(object sender, EventArgs e)
        {
            hidePopUpMenu();
            //Code...
        }
    }
}
