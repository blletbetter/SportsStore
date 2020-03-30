using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public sealed class Stick : HockeyProduct
    {
        public string Material { get; set; }
        public Player PlayerType { get; set; }
        public Grip Grip { get; set; }
        public double Length { get; set; }

        public Stick(string name, string supplier, double mass, decimal purchaseCost, decimal sellCost, decimal shipCost, int prodYear,
            string imageSource, List<HockeyItemSize> sizes, string description, string material, Player playerType, Grip grip, double length)
            : base(name, supplier, mass, purchaseCost, sellCost, shipCost, prodYear, imageSource, sizes, description)
        {
            this.Material = material;
            this.Grip = grip;
            this.PlayerType = playerType;
            this.Length = length;
        }

        public override string GetInfo()
        {
            string gripInfo = Grip == Grip.Left ? "Left" : "Right";
            string playerInfo = PlayerType == Player.Goalkeeper ? "Goalkeeper" : "Field player";
            return base.GetInfo() + $"Made of: {Material}\nLength: {Length}\nFor: {playerInfo}\nGrip: {gripInfo}\n";
        }
    }

    public enum Player
    {
        Goalkeeper = 0,
        FieldPlayer = 1
    }

    public enum Grip
    {
        Left = 0,
        Right = 1,
    }
}
