using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public sealed class DiscountCard : Card
    {
        public readonly Client owner;
        public double Discount { get; private set; }
        public decimal MoneySpentThisMonth { get; private set; }
        public bool IsActivated { get; private set; }

        public DiscountCard(DateTime expirationDate, Client owner)
        {
            IsActivated = true;
            MoneySpentThisMonth = 0;
            this.owner = owner;
            Discount = CountDiscount(MoneySpentThisMonth);
        }

        private double CountDiscount(decimal sum)
        {
            if (sum < 100)
            {
                return 0.05;
            }
            else if (sum > 100 && sum < 200)
            {
                return 0.08;
            }
            else if (sum > 200 && sum < 500)
            {
                return 0.08;
            }
            else
            {
                return 0.10;
            }
        }

        public decimal CountSumWithDiscount(decimal sum)
        {
            if (IsActivated)
            {
                return sum * (decimal)(1 - Discount);
            }
            else
            {
                return sum;
            }
        }

    }
}
