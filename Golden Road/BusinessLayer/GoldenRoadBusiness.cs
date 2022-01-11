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
        readonly GoldenRoadRepository goldenRoadtRepository = new GoldenRoadRepository();

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

    }
}
