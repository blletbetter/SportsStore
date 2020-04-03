using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class Admin : User
    {
        public DateTime DateOfAppointment { get; set; }
        public int Reputation { get; set; }

        public Admin(string name, int age,  string password, string passwordConfirmation, DateTime date, int reputation)
            : base(name, age, password, passwordConfirmation)
        {
            DateOfAppointment = date;
            Reputation = reputation;
        }

        public bool AddProductToStore(Store store, HockeyProduct hockeyProduct, string password, int amount = 1)
        {
            return store.AddProduct(hockeyProduct, password, amount);
        }

        public string Ban(Client c, string reason)
        {
            c = null;
            return reason;
        }
    }
}
