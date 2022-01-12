using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Models;

namespace Shared.Interfaces
{
    public interface IGoldenRoadRepository
    {
        List<User> GetAllUsers();
        int InsertUser(User user);

        List<Payment> GetAllPayments();
        int InsertPayment(Payment payment, User user);
    }
}
