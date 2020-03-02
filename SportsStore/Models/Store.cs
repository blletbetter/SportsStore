using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class Store
    {
        private List<Admin> admins;
        private List<DiscountCard> discountCards;
        private string password;
        public Dictionary<HockeyProduct, int> products { get; private set; }


        public Store(string password)
        {
            products = new Dictionary<HockeyProduct, int>();
            discountCards = new List<DiscountCard>();
            admins = new List<Admin>();
            this.password = password;
        }

        public void AddProduct(HockeyProduct product, string password, int amount = 1)
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
            }
            else
            {
                throw new ArgumentException("Login or password is incorrect");
            }
        }

        public void RegisterDiscountCard(Client client, string password)
        {
            if (client.CreateDiscountCard(1, password))
            {
                discountCards.Add(client.DiscountCard);
            }
            else
            {
                throw new ArgumentException("Something went wrong. Check if you have enough money or you have a discount card already");
            }
        }
    }
}
