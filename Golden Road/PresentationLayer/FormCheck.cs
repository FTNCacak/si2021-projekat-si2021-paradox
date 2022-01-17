using BusinessLayer;
using Shared.Models;
using Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FormCheck : Form
    {

        readonly GoldenRoadBusiness goldenRoadBusiness = new GoldenRoadBusiness();
        public List<User> allUsers;

        public FormCheck()
        {
            InitializeComponent();
            allUsers = goldenRoadBusiness.GetAllUsers();
        }

        private void FormCheck_Load(object sender, EventArgs e)
        {
            var users = allUsers;
            dataGridViewCheck.DataSource = users;
            dataGridViewCheck.Columns["Id"].Visible = false; 
        }


        private void buttonInsert_Click(object sender, EventArgs e)
        {
            goldenRoadBusiness.InsertUser(user);
            FormCheck_Load(sender, e);

            //dataGridViewCheck.AllowUserToAddRows = true;
            //dataGridViewCheck_UserAddedRow(sender, (MouseEventArgs)e);
        }


        User user = new User();

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            goldenRoadBusiness.DeleteUser(user.Id);
            dataGridViewCheck.AllowUserToDeleteRows = true;
            FormCheck_Load(sender, e); 
            
        }

        private void buttonUptade_Click(object sender, EventArgs e)
        {
            //goldenRoadBusiness.UpdateUser(user);
            //FormCheck_Load(sender, e);
            object DataSource = new object();
            Action d = new Action(() => { dataGridViewCheck.DataSource = DataSource; }); 
            dataGridViewCheck.Invoke(d);
        }
        

        private void dataGridViewCheck_UserAddedRow(object sender, MouseEventArgs e) {
            foreach (DataGridViewRow row in dataGridViewCheck.Rows)
            {
                string constring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GoldenRoadDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                using (SqlConnection con = new SqlConnection(constring))
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Users VALUES(@Ime, @Prezime, @Korisnicki_Id, @Lozinka, @JMBG, @Mail_Adresa, @Broj_Telefona, @Adresa, @Broj_Racuna, @Stanje_Na_Racunu)", con))
                    {
                        cmd.Parameters.AddWithValue("@Ime", row.Cells["Ime"].Value);
                        cmd.Parameters.AddWithValue("@Prezime", row.Cells["Prezime"].Value);
                        cmd.Parameters.AddWithValue("@Korisnicki_Id", row.Cells["Korisnicki_Id"].Value);
                        cmd.Parameters.AddWithValue("@Lozinka", row.Cells["Lozinka"].Value);
                        cmd.Parameters.AddWithValue("@JMBG", row.Cells["JMBG"].Value);
                        cmd.Parameters.AddWithValue("@Mail_Adresa", row.Cells["Mail_Adresa"].Value);
                        cmd.Parameters.AddWithValue("@Broj_Telefona", row.Cells["Broj_Telefona"].Value);
                        cmd.Parameters.AddWithValue("@Adresa", row.Cells["Adresa"].Value);
                        cmd.Parameters.AddWithValue("@Broj_Racuna", row.Cells["Broj_Racuna"].Value);
                        cmd.Parameters.AddWithValue("@Stanje_Na_Racunu", row.Cells["Stanje_Na_Racunu"].Value);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }
        }
    }
}
