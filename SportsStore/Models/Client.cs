using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class Client : User
    {
        public string Email { get; private set; }
        public DiscountCard DiscountCard { get; private set; }
        private Basket basket;
        private CreditCard creditCard;

        public Client(string name, int age, string password, string passwordConfirmation, string email) : base(name, age, password, passwordConfirmation)
        {
            Email = email;
            creditCard = null;
            basket = new Basket();
            DiscountCard = null;
        }

        public void AddItemToBasket(HockeyProduct item)
        {
            basket.AddItem(item);
        }

        public void AddCreditCard(CreditCard card)//remake
        {
            creditCard = card;
        }

        public bool CreateDiscountCard(int discountCardCost, string password)
        {
            if (creditCard != null)
            {
                return false;
            }
            else
            {
                if (creditCard.Pay(discountCardCost, password))
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
