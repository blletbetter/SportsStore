using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class Admin : User
    {
        protected DateTime dateOfAppointment;
        protected int reputation;

        public Admin(string name, int age,  string password, string passwordConfirmation, DateTime date, int reputation)
            : base(name, age, password, passwordConfirmation)
        {
            dateOfAppointment = date;
            this.reputation = reputation;
        }

        public string GetClientInfo(Client client)
        {
            return $"";
        }

        public void AddProductToStore(Store store, HockeyProduct hockeyProduct, string password, int amount = 1)
        {
            store.AddProduct(hockeyProduct, password, amount);
        }
    }
}
