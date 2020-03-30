using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class Store
    {
        public List<Admin> Admins { get; private set; }
        public List<DiscountCard> DiscountCards { get; private set; }
        private string password;
        public Dictionary<HockeyProduct, int> products { get; private set; }


        public Store(string password)
        {
            products = new Dictionary<HockeyProduct, int>();
            DiscountCards = new List<DiscountCard>();
            Admins = new List<Admin>();
            this.password = password;
        }

        public bool AddProduct(HockeyProduct product, string password, int amount = 1)
        {
            if(this.password == password)
            {
                if(products.ContainsKey(product))
                {
                    products[product] += amount;
                }
                else
                {
                    products.Add(product, amount);
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public void RegisterDiscountCard(Client client, string password)
        {
            if (client.CreateDiscountCard(1, password))
            {
                DiscountCards.Add(client.DiscountCard);
            }
            else
            {
                throw new ArgumentException("Something went wrong. Check if you have enough money or you have a discount card already");
            }
        }

        public decimal FullStoreProductsCost()
        {
            decimal sum = 0m;
            foreach(var i in products)
            {
                sum += i.Key.SellCost * i.Value;
            }
            return sum;
        }
    }
}
