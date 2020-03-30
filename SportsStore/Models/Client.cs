using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class Client : User
    {
        public string Email { get; set; }
        public DiscountCard DiscountCard { get; set; }
        public Basket Basket { get; set; }
        public CreditCard CreditCard { get; set; }

        public Client(string name, int age, string password, string passwordConfirmation, string email) : base(name, age, password, passwordConfirmation)
        {
            Email = email;
            CreditCard = null;
            Basket = new Basket();
            DiscountCard = null;
        }

        public void AddItemToBasket(HockeyProduct item)
        {
            Basket.AddItem(item);
        }

        public void AddCreditCard(CreditCard card)//remake
        {
            CreditCard = card;
        }

        public bool CreateDiscountCard(int discountCardCost, string password)
        {
            if (CreditCard == null || DiscountCard != null)
            {
                return false;
            }
            else
            {
                if (CreditCard.Pay(discountCardCost, password))
                {
                    DiscountCard = new DiscountCard(DateTime.Now, this);
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
