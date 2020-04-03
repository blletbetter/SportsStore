using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class HockeyProduct
    {
        public string Name { get; set; }
        public string Supplier { get; set; }
        public decimal Price { get; set; }
        public string ImageSource { get; set; }
        public  int ProductionYear { get; set; }
        public List<HockeyItemSize> Sizes { get; set; }
        public string Description { get; set; }

        public HockeyProduct(string name, string supplier, decimal price, int prodYear, string imageSource, List<HockeyItemSize> sizes, string description)
        {
            Name = name;
            Price = price;
            ImageSource = imageSource;
            Supplier = supplier;
            Sizes = sizes;
            Description = description;
            ProductionYear = prodYear;
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
            return HashCode.Combine(Name, Supplier, Price, ImageSource, ProductionYear, Sizes, Description);
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
