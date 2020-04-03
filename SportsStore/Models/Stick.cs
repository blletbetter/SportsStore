using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public sealed class Stick : HockeyProduct
    {
        public Player PlayerType { get; set; }
        public Grip Grip { get; set; }
        public double Length { get; set; }

        public Stick(string name, string supplier, decimal price, int prodYear, string imageSource, List<HockeyItemSize> sizes,
            string description, Grip grip, Player playerType, double length)
            : base(name, supplier, price, prodYear, imageSource, sizes, description)
        {
            Grip = grip;
            PlayerType = playerType;
            Length = length;
        }

        public override string GetInfo()
        {
            string gripInfo = Grip == Grip.Left ? "Left" : "Right";
            string playerInfo = PlayerType == Player.Goalkeeper ? "Goalkeeper" : "Field player";
            return base.GetInfo() + $"Length: {Length}\nFor: {playerInfo}\nGrip: {gripInfo}\n";
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
