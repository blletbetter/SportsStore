using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public abstract class User
    {
        public string Password { get; set; }
        public string Name { get; set; }
        protected int age { get; set; }
        public int Age 
        {
            get { return age; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age should be more than 0");
                }
                else
                {
                    age = value;
                }
            }
        }        

        public User(string name, int age, string password, string passwordConfirmation)
        {
            if (password != passwordConfirmation)
            {
                throw new ArgumentException("Passwords dont match");
            }
            else
            {
                Age = age;
                Name = name;
                Password = password;
            }
        }

        public bool LogIn(string name, string password)
        {
            if (Name == name && Password == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ChangePassword(string oldValue, string newValue, string newValueConfirmation)
        {
            if (Password == oldValue && newValue == newValueConfirmation)
            {
                Password = newValue;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
