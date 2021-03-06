using BusinessLayer;
using System;
using Shared.Models;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using static PresentationLayer.FormUser;
using Shared.Interfaces;

namespace PresentationLayer
{
    public partial class FormPayment : Form
    {
        //readonly IGoldenRoadBusiness goldenRoadBusiness;
        //public FormPayment(IGoldenRoadBusiness _goldenRoadBusiness)
        //{
        //    goldenRoadBusiness = _goldenRoadBusiness;
        //}

        readonly GoldenRoadBusiness goldenRoadBusiness = new GoldenRoadBusiness();
        public List<User> users = new List<User>();
        public static FormPayment fPinstance;
        public TextBox tbFromAcc, tbState;
        public FormPayment()
        {
            InitializeComponent();
            tbFromAcc = textBoxFromAcc;
            tbState = textBoxState;
        }

        private void buttonPayment_Click(object sender, EventArgs e)
        {

            if (textBoxAmount.Text == "" ||
                textBoxToAcc.Text == "" ||
                textBoxModel.Text == "" ||
                textBoxReference.Text == "" ||
                dateTimePickerDate.Value == null
                )
            {
                MessageBox.Show("Popunite sva tražena polja!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAmount.Focus();
                return;
            }


            if (!Regex.Match(textBoxName.Text, "^([A-Za-z]+[\\s][A-Za-z]*$)?").Success)
            {
                MessageBox.Show("Naziv nije pravilno unet!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxName.Focus();
                return;
            }


            if (!Regex.Match(textBoxAmount.Text, "^[0-9]+([.][0-9]{0,2})*$").Success)
            {
                MessageBox.Show("Iznos nije pravilno unet!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAmount.Focus();
                return;
            }


            if (!Regex.Match(textBoxToAcc.Text, "^[0-9]{18}").Success)
            {
                MessageBox.Show("Broj računa nije pravilno unet!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxToAcc.Focus();
                return;
            }

            if (!Regex.Match(textBoxPurpose.Text, "^([a-zA-Z0-9_]+( [a-zA-Z0-9_]+)*$)?").Success)
            {
                MessageBox.Show("Svrha plaćanja nije pravilno uneta!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPurpose.Focus();
                return;
            }

            if (!Regex.Match(textBoxModel.Text, "^[0-9]{2}").Success)
            {
                MessageBox.Show("Model nije pravilno unet!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxModel.Focus();
                return;
            }

            if (!Regex.Match(textBoxReference.Text, "^[0-9]{6}").Success)
            {
                MessageBox.Show("Poziv na broj nije pravilno unet!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxReference.Focus();
                return;
            }

            Payment payment = new Payment(textBoxName.Text, long.Parse(textBoxToAcc.Text), int.Parse(textBoxModel.Text), long.Parse(textBoxReference.Text), decimal.Parse(textBoxAmount.Text), textBoxPurpose.Text, Convert.ToString(dateTimePickerDate.Value));
            string tbState, tbAmount;
            decimal dState, dAmount;
            tbState = textBoxState.Text;
            tbAmount = textBoxAmount.Text;
            dState = Convert.ToDecimal(tbState);
            dAmount = Convert.ToDecimal(tbAmount);
            
            if(dState > dAmount)
            {
                goldenRoadBusiness.InsertPayment(payment, long.Parse(textBoxFromAcc.Text), textBoxAmount, textBoxState);
                MessageBox.Show("Uplata je primljena i čeka na izvršenje!", "Information Correct", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Nemate dovoljno novca na računu", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        User user = new User();

        private void dateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FormPayment_Load(object sender, EventArgs e)
        {
            //TextBox tb = new TextBox()
            //{
            //    Text = FormUser.sUserId
            //};

          
            goldenRoadBusiness.GetUser(FormUser.sUserId, textBoxFromAcc, textBoxState);
        }
    }
}
