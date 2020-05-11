using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WynikiSkokow.Data;

namespace WynikiSkokow.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WynikiSkokowContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<WynikiSkokowContext>>()))
            {
                // Look for any movies.
                if (context.Skoczek.Any())
                {
                    return;   // jesli jest cos w bazie
                }

                context.Skoczek.AddRange(
                    new Skoczek
                    {
                        Imie = "Marius",
                        Nazwisko = "Lindvik",
                        Kraj = "Norwegia",
                        Skok1 = 143.5M,
                        Skok2 = 136,
                        Punkty = 289.8M,
                        Miejsce = 1
                    },

                    new Skoczek
                    {
                        Imie = "Karl",
                        Nazwisko = "Geiger",
                        Kraj = "Niemcy",
                        Skok1 = 132,
                        Skok2 = 141,
                        Punkty = 282.1M,
                        Miejsce = 2
                    },

                    new Skoczek
                    {
                        Imie = "Dawid",
                        Nazwisko = "Kubacki",
                        Kraj = "Polska",
                        Skok1 = 137,
                        Skok2 = 139.5M,
                        Punkty = 284,
                        Miejsce = 3
                    },

                    new Skoczek
                    {
                        Imie = "Ryoyu",
                        Nazwisko = "Kobayashi",
                        Kraj = "Japonia",
                        Skok1 = 132,
                        Skok2 = 141,
                        Punkty = 273.4M,
                        Miejsce = 4
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
