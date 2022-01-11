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
                    user.JMBG = dataReader.GetInt64(5);
                    user.Mail_Adresa = dataReader.GetString(6);
                    user.Broj_Telefona = dataReader.GetInt64(7);
                    user.Adresa = dataReader.GetString(8);
                    user.Broj_Racuna_F = dataReader.GetInt64(9);
                    user.Broj_Racuna_S = dataReader.GetInt64(10);
                    user.Broj_Racuna_T = dataReader.GetInt64(11);
                    user.Stanje_Na_Racunu = dataReader.GetDecimal(12);

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
                command.CommandText = string.Format("INSERT INTO Users VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')",
                    user.Ime, user.Prezime, user.Korisnicki_Id, user.Lozinka, user.JMBG, user.Mail_Adresa, user.Broj_Telefona, user.Adresa, user.Broj_Racuna_F, user.Broj_Racuna_S, user.Broj_Racuna_T, user.Stanje_Na_Racunu);

                return command.ExecuteNonQuery();
            }


        }
        public int InsertPayment(Payment payment)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = string.Format("INSERT INTO Payments VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                  payment.Naziv, payment.Broj_Racuna_Primaoca, payment.Model, payment.Poziv_Na_Broj, payment.Iznos, payment.Svrha_Uplate, payment.Datum);

                return command.ExecuteNonQuery();
            }


        }


    }
}
