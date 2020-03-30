using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public sealed class Jersey : HockeyProduct
    {
        public  string PlayerSurname { get; set; }
        public  string Number { get; set; }
        public  string Team { get; set; }
        public  JerseyType JerseyType { get; set; }

        public Jersey(string name, string supplier, double mass, decimal purchaseCost, decimal sellCost, decimal shipCost, int prodYear,
            string imageSource, List<HockeyItemSize> sizes, string description, string playerSurname, string number, string team, JerseyType jerseyType)
            : base(name, supplier, mass, purchaseCost, sellCost, shipCost, prodYear, imageSource, sizes, description)
        {
            PlayerSurname = playerSurname;
            JerseyType = jerseyType;
            Team = team;
            Number = number;
        }

        public override string GetInfo()
        {
            string jerseyInfo = JerseyType == JerseyType.Home ? "Home" : "Away";
            return base.GetInfo() + $"Player: {PlayerSurname}\nNumber: {Number}\nTeam: {Team}\nJersey: {jerseyInfo}\n";
        }
    }

    public enum JerseyType
    {
        Home = 0,
        Away = 1,
    }
}
