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
                    },

                    new Character
                    {
                        Class_ID = "Warrior",
                        Character_Name = "Kramson",
                        Age = 250,
                        Background = "Undead warrior from a forgotten kingdom.",

                        Stats = new List<Stats> {
                            new Stats {Stats_Name = "vit", Stats_Number = 12},
                            new Stats {Stats_Name = "end", Stats_Number = 15},
                            new Stats {Stats_Name = "str", Stats_Number = 10},
                            new Stats {Stats_Name = "dex", Stats_Number = 13},
                            new Stats {Stats_Name = "int", Stats_Number = 9},
                            new Stats {Stats_Name = "att", Stats_Number = 6}
                        }    
                    },

                    new Character
                    {
                        Class_ID = "Sorcerer",
                        Character_Name = "Abalder",
                        Age = 20,
                        Background = "Up and coming mage.",

                        Stats = new List<Stats> {
                            new Stats {Stats_Name = "vit", Stats_Number = 8},
                            new Stats {Stats_Name = "end", Stats_Number = 10},
                            new Stats {Stats_Name = "str", Stats_Number = 8},
                            new Stats {Stats_Name = "dex", Stats_Number = 10},
                            new Stats {Stats_Name = "int", Stats_Number = 15},
                            new Stats {Stats_Name = "att", Stats_Number = 12}
                        }    
                    },

                    new Character
                    {
                        Class_ID = "Bandit",
                        Character_Name = "Wyll",
                        Age = 32,
                        Background = "Career criminal and a master theif.",

                        Stats = new List<Stats> {
                            new Stats {Stats_Name = "vit", Stats_Number = 10},
                            new Stats {Stats_Name = "end", Stats_Number = 14},
                            new Stats {Stats_Name = "str", Stats_Number = 12},
                            new Stats {Stats_Name = "dex", Stats_Number = 16},
                            new Stats {Stats_Name = "int", Stats_Number = 9},
                            new Stats {Stats_Name = "att", Stats_Number = 6}
                        }    
                    },

                    new Character
                    {
                        Class_ID = "Explorer",
                        Character_Name = "Cale",
                        Age = 28,
                        Background = "A man on a mission to map out uncharted lands.",

                        Stats = new List<Stats> {
                            new Stats {Stats_Name = "vit", Stats_Number = 9},
                            new Stats {Stats_Name = "end", Stats_Number = 12},
                            new Stats {Stats_Name = "str", Stats_Number = 10},
                            new Stats {Stats_Name = "dex", Stats_Number = 13},
                            new Stats {Stats_Name = "int", Stats_Number = 11},
                            new Stats {Stats_Name = "att", Stats_Number = 6}
                        }    
                    },

                    new Character
                    {
                        Class_ID = "Cleric",
                        Character_Name = "Peyra",
                        Age = 25,
                        Background = "A bastion of faith for a land lacking.",

                        Stats = new List<Stats> {
                            new Stats {Stats_Name = "vit", Stats_Number = 8},
                            new Stats {Stats_Name = "end", Stats_Number = 11},
                            new Stats {Stats_Name = "str", Stats_Number = 8},
                            new Stats {Stats_Name = "dex", Stats_Number = 10},
                            new Stats {Stats_Name = "int", Stats_Number = 13},
                            new Stats {Stats_Name = "att", Stats_Number = 10}
                        }    
                    },

                    new Character
                    {
                        Class_ID = "Swordsman",
                        Character_Name = "Roe",
                        Age = 43,
                        Background = "Veteran from a war most wish to forget.",

                        Stats = new List<Stats> {
                            new Stats {Stats_Name = "vit", Stats_Number = 12},
                            new Stats {Stats_Name = "end", Stats_Number = 14},
                            new Stats {Stats_Name = "str", Stats_Number = 14},
                            new Stats {Stats_Name = "dex", Stats_Number = 12},
                            new Stats {Stats_Name = "int", Stats_Number = 8},
                            new Stats {Stats_Name = "att", Stats_Number = 5}
                        }    
                    },

                    new Character
                    {
                        Class_ID = "Deprived",
                        Character_Name = "Gwyn",
                        Age = 473,
                        Background = "A wretched soul that refuses to rest.",

                        Stats = new List<Stats> {
                            new Stats {Stats_Name = "vit", Stats_Number = 10},
                            new Stats {Stats_Name = "end", Stats_Number = 16},
                            new Stats {Stats_Name = "str", Stats_Number = 12},
                            new Stats {Stats_Name = "dex", Stats_Number = 14},
                            new Stats {Stats_Name = "int", Stats_Number = 11},
                            new Stats {Stats_Name = "att", Stats_Number = 6}
                        }    
                    },

                    new Character
                    {
                        Class_ID = "Warrior",
                        Character_Name = "Nyrinn",
                        Age = 19,
                        Background = "Apprentice to a master, and is out to prove themselves.",

                        Stats = new List<Stats> {
                            new Stats {Stats_Name = "vit", Stats_Number = 12},
                            new Stats {Stats_Name = "end", Stats_Number = 12},
                            new Stats {Stats_Name = "str", Stats_Number = 14},
                            new Stats {Stats_Name = "dex", Stats_Number = 9},
                            new Stats {Stats_Name = "int", Stats_Number = 7},
                            new Stats {Stats_Name = "att", Stats_Number = 5}
                        }    
                    },

                    new Character
                    {
                        Class_ID = "Knight",
                        Character_Name = "Zaya",
                        Age = 21,
                        Background = "Sworn to protect her people.",

                        Stats = new List<Stats> {
                            new Stats {Stats_Name = "vit", Stats_Number = 11},
                            new Stats {Stats_Name = "end", Stats_Number = 11},
                            new Stats {Stats_Name = "str", Stats_Number = 10},
                            new Stats {Stats_Name = "dex", Stats_Number = 13},
                            new Stats {Stats_Name = "int", Stats_Number = 8},
                            new Stats {Stats_Name = "att", Stats_Number = 7}
                        }    
                    },

                    new Character
                    {
                        Class_ID = "Sorcerer",
                        Character_Name = "Yonio",
                        Age = 27,
                        Background = "Directly serves under the king.",

                        Stats = new List<Stats> {
                            new Stats {Stats_Name = "vit", Stats_Number = 8},
                            new Stats {Stats_Name = "end", Stats_Number = 11},
                            new Stats {Stats_Name = "str", Stats_Number = 8},
                            new Stats {Stats_Name = "dex", Stats_Number = 10},
                            new Stats {Stats_Name = "int", Stats_Number = 18},
                            new Stats {Stats_Name = "att", Stats_Number = 13}
                        }    
                    },

                    new Character
                    {
                        Class_ID = "Bandit",
                        Character_Name = "Pyke",
                        Age = 29,
                        Background = "An undead revenant seeking revenge.",

                        Stats = new List<Stats> {
                            new Stats {Stats_Name = "vit", Stats_Number = 10},
                            new Stats {Stats_Name = "end", Stats_Number = 13},
                            new Stats {Stats_Name = "str", Stats_Number = 14},
                            new Stats {Stats_Name = "dex", Stats_Number = 17},
                            new Stats {Stats_Name = "int", Stats_Number = 9},
                            new Stats {Stats_Name = "att", Stats_Number = 5}
                        }    
                    },

                    new Character
                    {
                        Class_ID = "Cleric",
                        Character_Name = "Aldia",
                        Age = 32,
                        Background = "Alleged holy woman with her own dark motives.",

                        Stats = new List<Stats> {
                            new Stats {Stats_Name = "vit", Stats_Number = 13},
                            new Stats {Stats_Name = "end", Stats_Number = 10},
                            new Stats {Stats_Name = "str", Stats_Number = 10},
                            new Stats {Stats_Name = "dex", Stats_Number = 12},
                            new Stats {Stats_Name = "int", Stats_Number = 14},
                            new Stats {Stats_Name = "att", Stats_Number = 10}
                        }    
                    },

                    new Character
                    {
                        Class_ID = "Explorer",
                        Character_Name = "Fendwyr",
                        Age = 24,
                        Background = "Native to the lush jungles, and a guide to lost travellers.",

                        Stats = new List<Stats> {
                            new Stats {Stats_Name = "vit", Stats_Number = 12},
                            new Stats {Stats_Name = "end", Stats_Number = 15},
                            new Stats {Stats_Name = "str", Stats_Number = 9},
                            new Stats {Stats_Name = "dex", Stats_Number = 16},
                            new Stats {Stats_Name = "int", Stats_Number = 9},
                            new Stats {Stats_Name = "att", Stats_Number = 5}
                        }    
                    },

                    new Character
                    {
                        Class_ID = "Swordsman",
                        Character_Name = "Tyra",
                        Age = 26,
                        Background = "Wandering soul looking for a purpose.",

                        Stats = new List<Stats> {
                            new Stats {Stats_Name = "vit", Stats_Number = 12},
                            new Stats {Stats_Name = "end", Stats_Number = 11},
                            new Stats {Stats_Name = "str", Stats_Number = 14},
                            new Stats {Stats_Name = "dex", Stats_Number = 11},
                            new Stats {Stats_Name = "int", Stats_Number = 8},
                            new Stats {Stats_Name = "att", Stats_Number = 7}
                        }    
                    },

                    new Character
                    {
                        Class_ID = "Deprived",
                        Character_Name = "Kos",
                        Age = 1000,
                        Background = "Some call her a myth, others call her a god.",

                        Stats = new List<Stats> {
                            new Stats {Stats_Name = "vit", Stats_Number = 20},
                            new Stats {Stats_Name = "end", Stats_Number = 20},
                            new Stats {Stats_Name = "str", Stats_Number = 20},
                            new Stats {Stats_Name = "dex", Stats_Number = 20},
                            new Stats {Stats_Name = "int", Stats_Number = 20},
                            new Stats {Stats_Name = "att", Stats_Number = 20}
                        }    
                    }
                );
                db.SaveChanges();
            }
        }
    }
}