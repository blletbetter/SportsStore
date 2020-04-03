using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SportsStore.Models
{
    public class HockeyProduct
    {
        [Key]
        public string Name { get; set; }
        public string Supplier { get; set; }
        public decimal Price { get; set; }
        public string ImageSource { get; set; }
        public  int ProductionYear { get; set; }
        //public List<HockeyItemSize> Sizes { get; set; }
        public string Description { get; set; }

        public HockeyProduct(string name, string supplier, decimal price, int productionYear, string imageSource, /*List<HockeyItemSize> sizes*/ string description)
        {
            Name = name;
            Supplier = supplier;
            Price = price;
            ProductionYear = productionYear;
            ImageSource = imageSource;
            //Sizes = sizes;
            Description = description;
        }

        public virtual string GetInfo()
        {
            string info = $"Name: {Name}\n";
            info += $"Supplier: {Supplier}\n";
            info += $"Price: {Price}\n";
            info += $"Production Year: {ProductionYear}\n";
            info += $"Description: {Description}\n";
            return info;
        }

        public override bool Equals(object obj)
        {
            if(obj == null || obj.GetType() != typeof(HockeyProduct))
            {
                return false;
            }
            else
            {
                var item = obj as HockeyProduct;
                if (Price == item.Price && Name == item.Name && Supplier == item.Supplier && ProductionYear == item.ProductionYear)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Supplier, Price, ImageSource, ProductionYear, Description);
        }

        public static bool operator ==(HockeyProduct a, HockeyProduct b)
        {
            if (a.Equals(b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(HockeyProduct a, HockeyProduct b)
        {
            return !(a == b);
        }
    }

    public enum HockeyItemSize
    {
        Child = 0,
        Junior = 1,
        Teenager = 2,
        Adult = 3
    }
}
