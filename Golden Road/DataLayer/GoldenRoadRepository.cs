using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Interfaces;
using Shared.Models;
namespace DataLayer
{
    public class GoldenRoadRepository : IGoldenRoadRepository
    {
        private string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GoldenRoadDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public List<User> GetAllUsers()
        {
            List<User> userList = new List<User>();

            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = "SELECT *FROM Users";


                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    User user = new User();
                    user.Id = dataReader.GetInt32(0);
                    user.Ime = dataReader.GetString(1);
                    user.Prezime = dataReader.GetString(2);
                    user.Korisnicki_Id = dataReader.GetString(3);
                    user.Lozinka = dataReader.GetString(4);
                    user.JMBG = dataReader.GetString(5);
                    user.Mail_Adresa = dataReader.GetString(6);
                    user.Broj_Telefona = dataReader.GetString(7);
                    user.Adresa = dataReader.GetString(8);
                    user.Broj_Racuna = dataReader.GetInt64(9);
                
                    user.Stanje_Na_Racunu = dataReader.GetDecimal(10);

                    userList.Add(user);

                }
            }
            return userList;
        }

        public List<Payment> GetAllPayments()
        {
            List<Payment> paymentList = new List<Payment>();

            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = "SELECT *FROM Payments";


                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Payment payment = new Payment();
                    payment.Id = dataReader.GetInt32(0);
                    payment.Naziv = dataReader.GetString(1);
                    payment.Broj_Racuna_Primaoca = dataReader.GetInt64(2);
                    payment.Model = dataReader.GetInt32(3);
                    payment.Poziv_Na_Broj = dataReader.GetInt64(4);
                    payment.Iznos = dataReader.GetDecimal(5);
                    payment.Svrha_Uplate = dataReader.GetString(6);
                    payment.Datum = dataReader.GetDateTime(7);
                    payment.Broj_Racuna_Uplatioca = dataReader.GetInt64(8);

                   paymentList.Add(payment);

                }
            }
            return paymentList;
        }

        public int InsertUser(User user)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = string.Format("INSERT INTO Users VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",
                    user.Ime, user.Prezime, user.Korisnicki_Id, user.Lozinka, user.JMBG, user.Mail_Adresa, user.Broj_Telefona, user.Adresa, user.Broj_Racuna, user.Stanje_Na_Racunu);

                return command.ExecuteNonQuery();
            }


        }
        public int InsertPayment(Payment payment, long broj_Racuna_Uplatioca)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = string.Format("INSERT INTO Payments VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                  payment.Naziv, payment.Broj_Racuna_Primaoca, payment.Model, payment.Poziv_Na_Broj, payment.Iznos, payment.Svrha_Uplate, payment.Datum, payment.Broj_Racuna_Uplatioca= broj_Racuna_Uplatioca);

                return command.ExecuteNonQuery();
            }


        }

        public int UpdateUser(User user)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                

                string sqlCommand = "UPDATE Users SET Ime = @Ime, Prezime = @Prezime, Korisnicki_Id = @Korisnicki_Id, Lozinka = @Lozinka," +
                    " JMBG = @JMBG , Mail_Adresa = @Mail_Adresa, Broj_Telefona = @Broj_Telefona, Adresa = @Adresa, Broj_Racuna= @Broj_Racuna," +
                    " Stanje_Na_Racunu = @Stanje_Na_Racunu WHERE Id = @Id";
                SqlCommand command = new SqlCommand(sqlCommand, sqlConnection);
                command.Parameters.AddWithValue("@Id", user.Id);
                command.Parameters.AddWithValue("@Ime", user.Ime);
                command.Parameters.AddWithValue("@Prezime", user.Prezime);
                command.Parameters.AddWithValue("@Korisnicki_Id", user.Korisnicki_Id);
                command.Parameters.AddWithValue("@Lozinka", user.Lozinka);
                command.Parameters.AddWithValue("@JMBG", user.JMBG);
                command.Parameters.AddWithValue("@Mail_Adresa", user.Mail_Adresa);
                command.Parameters.AddWithValue("@Broj_Telefona", user.Broj_Telefona);
                command.Parameters.AddWithValue("@Adresa", user.Adresa);
                command.Parameters.AddWithValue("@Broj_Racuna", user.Broj_Racuna);
              
                command.Parameters.AddWithValue("@Stanje_Na_Racunu", user.Stanje_Na_Racunu);

                sqlConnection.Open();

                return command.ExecuteNonQuery();
            }
        }
        public int UpdatePayment(Payment payment)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                

                string sqlCommand = "UPDATE Payments SET Naziv = @Naziv, Broj_Racuna_Primaoca = @Broj_Racuna_Primaoca, Model = @Model," +
                    " Poziv_Na_Broj = @Poziv_Na_Broj, Iznos = @Iznos, Svrha_Uplate = @Svrha_Uplate, Datum = @Datum WHERE Id = @Id";
                SqlCommand command = new SqlCommand(sqlCommand, sqlConnection);
                command.Parameters.AddWithValue("@Id", payment.Id);
                command.Parameters.AddWithValue("@Naziv", payment.Naziv);
                command.Parameters.AddWithValue("@Broj_Racuna_Primaoca", payment.Broj_Racuna_Primaoca);
                command.Parameters.AddWithValue("@Model", payment.Model);
                command.Parameters.AddWithValue("@Poziv_Na_Broj", payment.Poziv_Na_Broj);
                command.Parameters.AddWithValue("@Iznos", payment.Iznos);
                command.Parameters.AddWithValue("@Svrha_Uplate", payment.Svrha_Uplate);
                command.Parameters.AddWithValue("@Datum", payment.Datum);

                sqlConnection.Open();

                return command.ExecuteNonQuery();
            }
        }
        public int DeleteUser(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = "DELETE FROM Users WHERE Id = " + id;

                return command.ExecuteNonQuery();
            }
        }
        public int DeletePayment(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = "DELETE FROM Payments WHERE Id = " + id;

                return command.ExecuteNonQuery();
            }
        }

    }
}
