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
    public class GoldenRoadBusiness:IGoldenRoadBusiness
    {
        readonly GoldenRoadRepository goldenRoadRepository = new GoldenRoadRepository();

        public List<User> GetAllUsers()
        {
            return this.goldenRoadRepository.GetAllUsers();
        }
        public List<Payment> GetAllPayments()
        {
            return this.goldenRoadRepository.GetAllPayments();
        }

        public bool InsertUser(User user)
        {
            int rowsAffected = this.goldenRoadRepository.InsertUser(user);
            if (rowsAffected > 0)
                return true;
            else
                return false;
        }

        public bool InsertPayment(Payment payment, long broj_Racuna_Uplatioca)
        {
            //kod
            return true;
        }

        public bool UpdateUser(User user)
        {
            int rowsAffected = this.goldenRoadRepository.UpdateUser(user);
            if (rowsAffected > 0)
                return true;
            else
                return false;
        }

        public bool DeleteUser(int id)
        {
            int rowsAffected = this.goldenRoadRepository.DeleteUser(id);
            if (rowsAffected > 0)
                return true;
            else
                return false;
        }
    }
}
