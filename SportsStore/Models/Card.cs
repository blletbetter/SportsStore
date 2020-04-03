using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public abstract class Card
    {
        public readonly DateTime expirationDate;
        public readonly int id;
        public readonly string stringId;
        public static int ID;
        
        static Card()
        {
            ID = 0;
        }
        public Card()
        {
            ID++;
            id = ID;
            expirationDate = DateTime.Now.AddYears(3);
        }

        public Card(DateTime expirationDate)
        {
            this.expirationDate = expirationDate;
            ID++;
            id = ID;
            stringId = GenerateStringId();
        }

        public virtual string GetInfo()
        {
            string info = $"Id: {stringId}";
            info += "\nExpiration Date: {expirationDate}\n";
            return info;
        }

        protected string GenerateStringId()
        {
            int i = 0, checkId = id;
            string temp = "";
            for(; checkId > 0; i++)
            {
                checkId /= 10;
            }
            while(16 - i > 0)
            {
                temp += (new Random().Next(0,9)).ToString();
                i++;
            }
            temp += id.ToString();
            return temp;
        }
    }
}
