using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public sealed class Skates : HockeyProduct
    {
        public string Material { get; set; }

        public Skates(string name, string supplier, double mass, decimal purchaseCost, decimal sellCost, decimal shipCost, int prodYear, string imageSource,
            List<HockeyItemSize> sizes, string description, string material) : base(name, supplier, mass, purchaseCost, sellCost, shipCost, prodYear, imageSource,
                sizes, description)
        {
            this.Material = material;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $"Made of: {Material}\n";
        }
    }
}
