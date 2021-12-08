using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

namespace CIDM_3312_Final_Project.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var db = new CharacterContext(serviceProvider.GetRequiredService<DbContextOptions<CharacterContext>>()))
            {
                if (db.Character.Any())
                {
                    return;
                }

                db.Character.AddRange(
                    new Character
                    {
                        Class_ID = "Knight",
                        Character_Name = "Sora",
                        Age = 23,
                        Background = "This soul hails from this cursed land.",

                        Stats = new List<Stats> {
                            new Stats {Stats_Name = "vit", Stats_Number = 9},
                            new Stats {Stats_Name = "end", Stats_Number = 11},
                            new Stats {Stats_Name = "str", Stats_Number = 14},
                            new Stats {Stats_Name = "dex", Stats_Number = 12},
                            new Stats {Stats_Name = "int", Stats_Number = 8},
                            new Stats {Stats_Name = "att", Stats_Number = 7}
                        }
                    }
                );
                db.SaveChanges();
            }
        }
    }
}