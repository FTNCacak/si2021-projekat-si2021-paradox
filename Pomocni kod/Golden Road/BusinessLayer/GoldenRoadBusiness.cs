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
            return goldenRoadRepository.GetAllUsers();
        }

        public bool InsertUser(User user)
        {
            return goldenRoadRepository.InsertUser(user) != 0;
        }

        public bool InsertPayment(Payment payment, long broj_Racuna_Uplatioca)
        {
            return goldenRoadRepository.InsertPayment(payment, broj_Racuna_Uplatioca) != 0;
        }

        public List<Payment> GetAllPayments()
        {
            throw new NotImplementedException();
        }

    }
}
