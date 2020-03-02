using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public sealed class Basket
    {
        private Dictionary<HockeyProduct, int> products;
        public decimal TotalCost { get; private set; }

        public Basket()
        {
            products = default;
            TotalCost = default;
        }

        public Basket(Dictionary<HockeyProduct, int> products)
        {
            this.products = products;
            TotalCost = CountTotal();
        }

        public decimal CountTotal()
        {
            decimal sum = 0m;
            foreach (var item in products)
            {
                sum += item.Key.SellCost * item.Value;
            }
            return sum;
        }

        public void AddItem(HockeyProduct item, int amount = 1)
        {
            if (products.ContainsKey(item))
            {
                products[item] += amount;
            }
            else
            {
                products.Add(item, amount);
            }
        }

    }
}
