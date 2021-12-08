using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
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
                        Background = "This soul hails from this cursed land."
                    }
                );
                db.SaveChanges();
            }
        }
    }
}