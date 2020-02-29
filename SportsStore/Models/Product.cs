using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public abstract class Product
    {
        public readonly decimal purchaseCost;
        public readonly double mass;
        public readonly string name;
        public string Supplier { get; protected set; }
        public decimal SellCost { get; protected set; }
        public decimal ShipCost { get; private set; }     
        
        public Product()
        {
            purchaseCost = default;
            mass = default;
            SellCost = default;
            ShipCost = default;
            Supplier = default;
            name = default;
        }

        public Product(string name, string supplier, double mass, decimal purchaseCost, decimal sellCost, decimal shipCost)
        {
            this.purchaseCost = purchaseCost;
            this.mass = mass;
            this.name = name;
            SellCost = sellCost;
            ShipCost = shipCost;
            Supplier = supplier;
        }

        public string GetInfo()
        {
            string info;
            info = $"Name: {name}\n";
            info = String.Concat(info, $"Supplier: {Supplier}\n");
            info = String.Concat(info, $"Mass: {mass}\n");
            info = String.Concat(info, $"Purchase Cost: {purchaseCost}\n");
            info = String.Concat(info, $"Ship Cost: {ShipCost}\n");
            info = String.Concat(info, $"Sell Cost: {SellCost}");
            return info;
        }

        public override string ToString()
        {
            return base.ToString() + '\n' + GetInfo();
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Product p = obj as Product;
                return (p.name == name) && (p.mass == mass) && (p.Supplier == Supplier) && (p.ShipCost == ShipCost)
                    && (p.SellCost == SellCost) && (p.purchaseCost == purchaseCost);
            }
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(purchaseCost, mass, name, Supplier, SellCost, ShipCost);
        }

        public static bool operator ==(Product a, Product b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(Product a, Product b)
        {
            return !(a == b);
        }
    }
}
