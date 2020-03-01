using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class HockeyProduct : Product
    {
        public readonly int productionYear;
        public List<HockeyItemSize> sizes { get; protected set; }
        public string Description { get; protected set; }

        public HockeyProduct(string name, string supplier, double mass, decimal purchaseCost, decimal sellCost, decimal shipCost, int prodYear, 
            List<HockeyItemSize> sizes, string description) : base(name, supplier, mass, purchaseCost, sellCost, shipCost)
        {
            this.sizes = sizes;
            Description = description;
            productionYear = prodYear;
        }

        public List<HockeyProduct> DescriptionSearch(List<HockeyProduct> items, string description)
        {
            return new List<HockeyProduct>(items.Where(i => i.Description.Contains(description)));
        } 

        public override string GetInfo()
        {
            return $"Name: {name}\nSupplier: {Supplier}\nMass: {mass}\nProduction Year: {productionYear}\nCost: {SellCost}\nDescription: {Description}\n";
        }
    }

    public enum HockeyItemSize
    {
        Child = 0,
        Junior = 1,
        Teenager = 2,
        Adult = 3
    }
}
