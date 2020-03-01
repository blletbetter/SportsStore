using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public sealed class Skates : HockeyProduct
    {
        public readonly string material;

        public Skates(string name, string supplier, double mass, decimal purchaseCost, decimal sellCost, decimal shipCost, int prodYear,
            List<HockeyItemSize> sizes, string description, string material) : base(name, supplier, mass, purchaseCost, sellCost, shipCost, prodYear, sizes, description)
        {
            this.material = material;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $"Made of: {material}\n";
        }
    }
}
