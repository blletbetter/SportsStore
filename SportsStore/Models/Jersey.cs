using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public sealed class Jersey : HockeyProduct
    {
        public readonly string playerSurname;
        public readonly string number;
        public readonly string team;
        public readonly JerseyType jerseyType;

        public Jersey(string name, string supplier, double mass, decimal purchaseCost, decimal sellCost, decimal shipCost, int prodYear,
            List<HockeyItemSize> sizes, string description, string playerSurname, string number, string team, JerseyType jerseyType)
            : base(name, supplier, mass, purchaseCost, sellCost, shipCost, prodYear, sizes, description)
        {
            this.playerSurname = playerSurname;
            this.jerseyType = jerseyType;
            this.team = team;
            this.number = number;
        }

        public override string GetInfo()
        {
            string jerseyInfo = jerseyType == JerseyType.Home ? "Home" : "Away";
            return base.GetInfo() + $"Player: {playerSurname}\nNumber: {number}\nTeam: {team}\nJersey: {jerseyInfo}\n";
        }
    }

    public enum JerseyType
    {
        Home = 0,
        Away = 1,
    }
}
