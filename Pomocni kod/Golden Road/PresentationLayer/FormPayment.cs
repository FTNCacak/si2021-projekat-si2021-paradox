using BusinessLayer;
using System;
using Shared.Models;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using static PresentationLayer.FormUser;
using System.Collections.Generic;

namespace PresentationLayer
{
    public partial class FormPayment : Form
    {
        public List<User> users = new List<User>();
        public static FormPayment instance;
        private string userId = Global.UserID;
        readonly GoldenRoadBusiness goldenRoadBusiness = new GoldenRoadBusiness();
        public FormPayment()
        {
            InitializeComponent();
            instance = this;
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

            Payment payment = new Payment(textBoxName.Text, long.Parse(textBoxToAcc.Text), int.Parse(textBoxModel.Text), long.Parse(textBoxReference.Text), decimal.Parse(textBoxAmount.Text), textBoxPurpose.Text, dateTimePickerDate.Value);

            goldenRoadBusiness.InsertPayment(payment, long.Parse(textBoxFromAcc.Text));

            MessageBox.Show("Uplata je primljena i čeka na izvršenje!", "Information Correct", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        //izmena

        User user = new User();
        private void FormPayment_Load(object sender, EventArgs e)
        {
            string conString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GoldenRoadDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            using (SqlConnection con = new SqlConnection(conString))
            {
                for(int i=0; i<users.Count; i++){
                   //if (users[i].Korisnicki_Id == userId) {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE Korisnicki_Id = userId"))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            reader.Read();
                            textBoxFromAcc.Text = Convert.ToString(reader["Ime"]);

                            //ovde sam pokusala da testiram i sa imenom jer je string tipa, ali nije uspelo, niti poput drugog komentara
                            //treci komentar radi
                                //textBoxFromAcc.Text = sdr.GetString(long.Parse(user.Broj_Racuna));
                            //textBoxStanje.Text = Convert.ToString(sdr["Stanje_Na_Racunu"]);
                        }
                        con.Close();
                    }
               // } 
                
                }
                
            }

        }
    }
}
