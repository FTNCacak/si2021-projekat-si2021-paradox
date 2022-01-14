using DataLayer;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Interfaces;

namespace BusinessLayer
{
    public class GoldenRoadBusiness : IGoldenRoadBusiness
    {
        private readonly IGoldenRoadBusiness iGoldenRoadBusiness;

        readonly GoldenRoadRepository goldenRoadtRepository = new GoldenRoadRepository();
        public GoldenRoadBusiness(IGoldenRoadBusiness _grRepository)
        {
            iGoldenRoadBusiness = _grRepository;
        }
        public List<User> GetAllUsers()
        {
            return goldenRoadtRepository.GetAllUsers();
        }

        public bool InsertUser(User user)
        {
            return goldenRoadtRepository.InsertUser(user) != 0;
        }

        public bool InsertPayment(Payment payment)
        {
            return goldenRoadtRepository.InsertPayment(payment) != 0;
        }

        public List<Payment> GetAllPayments()
        {
            throw new NotImplementedException();
        }
        public string UpdateUser(User user)
        {
            int rowsAffected = this.goldenRoadtRepository.UpdateUser(user);

            if (rowsAffected > 0)
            {
                return "Uspešna izmena ";
            }
            else
            {
                return "Neuspešna izmena";
            }
        }
        public string UpdatePayment(Payment payment)
        {
            int rowsAffected = this.goldenRoadtRepository.UpdatePayment(payment);

            if (rowsAffected > 0)
            {
                return "Uspešna izmena ";
            }
            else
            {
                return "Neuspešna izmena";
            }
        }
        public string DeleteUser(int id)
        {
            int rowsAffected = this.goldenRoadtRepository.DeleteUser(id);

            if (rowsAffected > 0)
            {
                return "Uspešno obrisan podatak ";
            }
            else
            {
                return "Brisanje podatka nije uspelo";
            }
        }
        public string DeletePayment(int id)
        {
            int rowsAffected = this.goldenRoadtRepository.DeletePayment(id);

            if (rowsAffected > 0)
            {
                return "Uspešno obrisan podatak ";
            }
            else
            {
                return "Brisanje podatka nije uspelo";
            }
        }

        public bool InsertPayment(Payment payment, User user)
        {
            throw new NotImplementedException();
        }



        public bool InsertPayment(Payment payment, long broj_Racuna_Uplatioca)
        {
            throw new NotImplementedException();
        }
        private User user2 = new User
        {

            Korisnicki_Id = "perke00",
            Lozinka = "lm1154",


        };
     

        public string LogIn(string Id, string pas)
        {


            string id = Id;
            string pa = pas;
            InsertUser(user2);
            return id + " " + pa;

        }
        public bool Uplata(decimal stanje, decimal iznos) {
            decimal x = 0;
            decimal y = 0;
            if (iznos < 5001)
            {

                x= iznos + 50;
            }
            else {
                 y= iznos + (iznos / 100);
            }
           
            if ((stanje - x) > 0 || (stanje - y) > 0)
            {
                return false;
            }
            else { return true; }
        
        }
    }
}
