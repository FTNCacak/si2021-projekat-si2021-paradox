using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Models;
using System.Windows.Forms;

namespace Shared.Interfaces
{
    public interface IGoldenRoadRepository
    {
        List<User> GetAllUsers();
        int InsertUser(User user);
        int DeleteUser(int id);
        int UpdateUser(User user);

        List<Payment> GetAllPayments();
        int InsertPayment(Payment payment, long broj_Racuna_Uplatioca, TextBox tbAmount, TextBox tbState);
        List<User> GetUser(string tbUserId, TextBox tbFromAcc, TextBox tbState);
    }
}
