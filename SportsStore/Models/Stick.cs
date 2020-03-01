using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public sealed class Stick : HockeyProduct
    {
        public readonly string material;
        public readonly Player playerType;
        public readonly Grip grip;
        public readonly double length;

        public Stick(string name, string supplier, double mass, decimal purchaseCost, decimal sellCost, decimal shipCost, int prodYear,
            List<HockeyItemSize> sizes, string description, string material, Player playerType, Grip grip, double length)
            : base(name, supplier, mass, purchaseCost, sellCost, shipCost, prodYear, sizes, description)
        {
            this.material = material;
            this.grip = grip;
            this.playerType = playerType;
            this.length = length;
        }

        public override string GetInfo()
        {
            string gripInfo = grip == Grip.Left ? "Left" : "Right";
            string playerInfo = playerType == Player.Goalkeeper ? "Goalkeeper" : "Field player";
            return base.GetInfo() + $"Made of: {material}\nLength: {length}\nFor: {playerInfo}\nGrip: {gripInfo}\n";
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
