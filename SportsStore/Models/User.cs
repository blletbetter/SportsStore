using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public abstract class User
    {
        protected string password;
        public readonly string name;
        public int Age 
        {
            get { return Age; }
            set
            {
                if (Age <= 0)
                    throw new ArgumentException("Age should be more than 0");
                else
                    Age = value;
            }
        }
        

        public User(string name, int age, string password, string passwordConfirmation)
        {
            if (password != passwordConfirmation)
                throw new ArgumentException("Passwords dont match");
            else
            {
                this.Age = age;
                this.name = name;
                this.password = password;
            }
        }

        public bool LogIn(string name, string password)
        {
            if (this.name == name && this.password == password)
                return true;
            else
                return false;
        }

        public bool ChangePassword(string oldValue, string newValue, string newValueConfirmation)
        {
            if (password == oldValue && newValue == newValueConfirmation)
            {
                password = newValue;
                return true;
            }
            else
                throw new ArgumentException("Wrong Input");
        }
    }
}
