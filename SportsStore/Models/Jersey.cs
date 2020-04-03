using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public sealed class Jersey : HockeyProduct
    {
        public  string PlayerSurname { get; set; }
        public  int? Number { get; set; }
        public  string Team { get; set; }
        public  JerseyType JerseyType { get; set; }

        public Jersey(string name, string supplier, decimal price, int productionYear, string imageSource, /*List<HockeyItemSize> sizes*/ string description,
        JerseyType jerseyType, string team, int? number, string playerSurname)
            : base(name, supplier, price, productionYear, imageSource, description)
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
