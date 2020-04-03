using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public sealed class Helmet : HockeyProduct
    {
        public bool IsGlassed { get; set; }
        public Player PlayerType { get; set; }

        public Helmet(string name, string supplier, decimal price, int productionYear, string imageSource, /*List<HockeyItemSize> sizes*/ string description
            ,bool isGlassed, Player playerType)
            : base(name, supplier, price, productionYear, imageSource, description)
        {
            IsGlassed = isGlassed;
            PlayerType = playerType;
        }

        public override string GetInfo()
        {
            string glassInfo = IsGlassed ? "Yes" : "No";
            string playerInfo = PlayerType == Player.Goalkeeper ? "Goalkeeper" : "Field player";
            return base.GetInfo() + $"For: {playerInfo}\nIs Glassed: {glassInfo}\n";
        }
    }
}
