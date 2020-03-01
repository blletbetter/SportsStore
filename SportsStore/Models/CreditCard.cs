using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public sealed class CreditCard : Card
    {
        public readonly string ownerName;
        private readonly int CVN;
        private string password;
        private decimal money;
        private bool blocked;

        public CreditCard(DateTime expirationDate, string ownerName, string password, int cvn) : base(expirationDate)
        {
            this.ownerName = ownerName;
            this.password = password;
            CVN = cvn;
            money = 0;
        }

        public void Block()
        {
            blocked = true;
        }

        public void UnBlock(string newPassword)
        {
            password = newPassword;
        }

        public bool Pay(decimal sum)
        {
            if (blocked)
                return false;
            else
            {
                if (money >= sum)
                {
                    money -= sum;
                    return true;
                }
                else
                    return false;
            }
        }

        public void AddMoney(decimal sum)
        {
            money += sum;
        }
    }
}
