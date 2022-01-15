using DataLayer;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Interfaces;
using System.Windows.Forms;

namespace BusinessLayer
{
    public class GoldenRoadBusiness : IGoldenRoadBusiness
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

        public List<User> GetUser(TextBox tbUserId, TextBox tbFromAcc, TextBox tbState)
        {
            return this.goldenRoadRepository.GetUser(tbUserId, tbFromAcc, tbState);
        }

        public bool InsertUser(User user)
        {
            int rowsAffected = this.goldenRoadRepository.InsertUser(user);
            if (rowsAffected > 0)
                return true;
            else
                return false;
        }

        public bool InsertPayment(Payment payment, long broj_Racuna_Uplatioca, TextBox tbAmount, TextBox tbState)
        {
            string textAmount = tbAmount.Text;
            string textState = tbState.Text;
            decimal valueAmount = Convert.ToDecimal(textAmount);
            decimal valueState = Convert.ToDecimal(textState);
            if (valueAmount <= 5000)
            {
                valueAmount = valueAmount + 50;
                valueState = valueState - valueAmount;
                tbAmount.Text = valueAmount.ToString();
                tbState.Text = valueState.ToString();
            }
            else
            {
                valueAmount = valueAmount + valueAmount / 100;
                valueState = valueState - valueAmount;
                tbAmount.Text = valueAmount.ToString();
                tbState.Text = valueState.ToString();
            }
            int rowsAffected = this.goldenRoadRepository.InsertPayment(payment, broj_Racuna_Uplatioca, tbAmount, tbState);
            if (rowsAffected > 0)
               return true;
            else
               return false;             
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
