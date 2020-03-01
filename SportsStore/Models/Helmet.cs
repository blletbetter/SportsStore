using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public sealed class Helmet : HockeyProduct
    {
        public readonly bool isGlassed;
        public Player playerType;

        public Helmet(string name, string supplier, double mass, decimal purchaseCost, decimal sellCost, decimal shipCost, int prodYear,
           List<HockeyItemSize> sizes, string description, bool isGlassed, Player playerType)
            : base(name, supplier, mass, purchaseCost, sellCost, shipCost, prodYear, sizes, description)
        {
            this.isGlassed = isGlassed;
            this.playerType = playerType;
        }

        public override string GetInfo()
        {
            string glassInfo = isGlassed ? "Yes" : "No";
            string playerInfo = playerType == Player.Goalkeeper ? "Goalkeeper" : "Field player";
            return base.GetInfo() + $"For: {playerInfo}\nIs Glassed: {glassInfo}\n";
        }
    }
}
