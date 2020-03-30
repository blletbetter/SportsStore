using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public sealed class CreditCard : Card
    {
        public string OwnerName { get; set; }
        public int CVN { get; set; }
        public string Password { get; set; }
        public decimal Balance { get; private set; }
        private bool blocked;

        public CreditCard(DateTime expirationDate, string ownerName, string password, int cvn) : base(expirationDate)
        {
            this.OwnerName = ownerName;
            this.Password = password;
            CVN = cvn;
            Balance = 0;
        }

        public void Block()
        {
            blocked = true;
        }

        public bool UnBlock(string newPassword, string passwordConfirmation)
        {
            if(newPassword == passwordConfirmation)
            {
                Password = newPassword;
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public bool Pay(decimal sum, string password)
        {
            if (password == Password && !blocked && Balance >= sum)
            {                        
                Balance -= sum;
                return true;           
            }
            else
            {
                return false;
            }
        }

        public void AddMoney(decimal sum)
        {
            Balance += sum;
        }
    }
}
