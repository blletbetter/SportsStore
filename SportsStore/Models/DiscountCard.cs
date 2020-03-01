using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public sealed class DiscountCard : Card
    {
        public readonly Client owner;
        private double discount;
        private decimal moneySpentThisMonth;
        public bool IsActivated { get; private set; }

        public DiscountCard(DateTime expirationDate, Client owner)
        {
            IsActivated = true;
            moneySpentThisMonth = 0;
            this.owner = owner;
            discount = CountDiscount(moneySpentThisMonth);
        }

        private double CountDiscount(decimal sum)
        {
            if (sum < 100)
                return 0.05;
            else if (sum < 200)
                return 0.06;
            else if (sum < 500)
                return 0.08;
            else
                return 0.10;
        }

        public decimal CountSumWithDiscount(decimal sum)
        {
            if (IsActivated)
                return sum * (decimal)(1 - discount);
            else
                return sum;
        }

    }
}
