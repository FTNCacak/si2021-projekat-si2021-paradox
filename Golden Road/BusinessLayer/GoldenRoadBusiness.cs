using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class GoldenRoadBusiness
    {
        readonly GoldenRoadRepository goldenRoadtRepository = new GoldenRoadRepository();

        public List<GoldenRoad> GetUsers()
        {
            return goldenRoadtRepository.GetAllUsers();
        }

        public bool InsertUsers(User user)
        {
            return goldenRoadtRepository.InsertUser(user) != 0;
        }

        public bool InsertPayment(Payment payment)
        {
            return goldenRoadtRepository.InsertPayment(payment) != 0;
        }
    }
}
