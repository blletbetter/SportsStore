using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<HockeyProduct> Products => new List<HockeyProduct>()
        {
            new Stick("stick", "CCM", 100, 2015, "", "good", Grip.Left, Player.FieldPlayer, 1.00),
            new Helmet("helmet", "CCM", 100, 2014, "", "fine", true, Player.Goalkeeper)
        }.AsQueryable<HockeyProduct>();
    }
}
