using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Models;

namespace Shared.Interfaces
{
    public interface IGoldenRoadBusiness
    {
        List<User> GetAllUsers();
        bool InsertUser(User user);
        bool UpdateUser(User user);
        bool DeleteUser(int id);
        List<Payment> GetAllPayments();
        bool InsertPayment(Payment payment, long broj_Racuna_Uplatioca);
    }
}
