using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public sealed class Skates : HockeyProduct
    {
        public string Material { get; set; }

        public Skates(string name, string supplier, decimal price, int productionYear, string imageSource, /*List<HockeyItemSize> sizes*/ 
            string description, string material)
            : base(name, supplier, price, productionYear, imageSource, description)
        {
            Material = material;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $"Made of: {Material}\n";
        }
    }
}
