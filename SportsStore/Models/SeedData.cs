using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace SportsStore.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ProductDbContext context = app.ApplicationServices.GetRequiredService<ProductDbContext>();
            context.Database.EnsureCreated();
            if(!context.Products.Any())
            {
                context.Products.AddRange(new List<HockeyProduct>(){
                    new HockeyProduct("stick1", "CCM", 200m, 2011, "", new List<HockeyItemSize> { HockeyItemSize.Adult },"good" ),
                    new HockeyProduct("stick2", "CCM", 205m, 2011, "", new List<HockeyItemSize> { HockeyItemSize.Adult },"good" ),
                    new HockeyProduct("stick3", "CCM", 202m, 2011, "", new List<HockeyItemSize> { HockeyItemSize.Adult },"good" ),
                    new HockeyProduct("stick4", "CCM", 201m, 2011, "", new List<HockeyItemSize> { HockeyItemSize.Adult },"good" ),
                    new HockeyProduct("stick5", "CCM", 203m, 2011, "", new List<HockeyItemSize> { HockeyItemSize.Adult},"good" ),
                });
            }
        }
    }
}
