using BusinessLayer;
using Shared.Models;
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
            var users = this.allUsers;
            dataGridViewCheck.DataSource = users;
            dataGridViewCheck.Columns["Id"].Visible = false;
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            goldenRoadBusiness.InsertUser(user);
            FormCheck_Load(sender, e); //refresh

            //neuspeli pokusaj
            /*string connString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GoldenRoadDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection sqlConnection = new SqlConnection(connString);

            for (int i = 0; i < dataGridViewCheck.Rows.Count - 1; i++) {
                SqlCommand cmd = new SqlCommand(@"INSERT INTO Users (Ime, Prezime, Korisnicki_Id, Lozinka, JMBG, Mail_Adresa, Broj_Telefona, Adresa, Broj_Racuna, Stanje_Na_Racunu)"+ dataGridViewCheck.Rows[i].Cells[0].Value + dataGridViewCheck.Rows[i].Cells[1].Value + dataGridViewCheck.Rows[i].Cells[2].Value + dataGridViewCheck.Rows[i].Cells[3].Value + dataGridViewCheck.Rows[i].Cells[4].Value + dataGridViewCheck.Rows[i].Cells[5].Value + dataGridViewCheck.Rows[i].Cells[6].Value + dataGridViewCheck.Rows[i].Cells[7].Value + dataGridViewCheck.Rows[i].Cells[8].Value);
                sqlConnection.Open();
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
            }*/
        }


        User user = new User();

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            goldenRoadBusiness.DeleteUser(user.Id);
            FormCheck_Load(sender, e); 
        }

        private void buttonUptade_Click(object sender, EventArgs e)
        {
            goldenRoadBusiness.UpdateUser(user);
            FormCheck_Load(sender, e); 
        }
    }
}
