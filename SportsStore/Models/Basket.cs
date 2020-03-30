using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public sealed class Basket
    {
        public Dictionary<HockeyProduct, int> Products;
        public decimal TotalCost { get; private set; }

        public Basket()
        {
            Products = new Dictionary<HockeyProduct, int>();
            TotalCost = default;
        }

        public Basket(Dictionary<HockeyProduct, int> products)
        {
            Products = products;
            TotalCost = CountTotal();
        }

        public decimal CountTotal()
        {
            decimal sum = 0m;
            foreach (var item in Products)
            {
                sum += item.Key.SellCost * item.Value;
            }
            return sum;
        }

        public void AddItem(HockeyProduct item, int amount = 1)
        {
            if (Products.ContainsKey(item))
            {
                Products[item] += amount;
            }
            else
            {
                Products.Add(item, amount);
            }
        }


        public List<HockeyProduct> DescriptionSearch(string description)
        {
            return new List<HockeyProduct>(Products.Keys.Where(i => i.Description.Contains(description)));
        }

    }
}
