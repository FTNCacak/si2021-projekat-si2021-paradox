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
    public partial class FormRegister : Form
    {
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
            FormGoldenRoad.fGRinstance.btnLogin.Visible = false;
            FormGoldenRoad.fGRinstance.btnRegister.Visible = false;
            FormGoldenRoad.fGRinstance.btnLogout.Visible = true;
            FormGoldenRoad.fGRinstance.btnPayment.Visible = true;
            openChildForm(new FormYHSR());
            //Staviti sve ovo u uslov koji je ispunjen
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {
        
        }
    }
}
