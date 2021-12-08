using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CIDM_3312_Final_Project.Models
{
    public class Stats
    {
        public int StatsId {get; set;}	// Primary Key

        public string Stats_Name {get; set;}

        [Range(5,20)]
        [Required]
        public int Stats_Number {get; set;}

        [Display(Name = "Character")]
        [Required]
        public int CharacterId {get; set;} //Foreign Key linking Stats to Character

        public Character Character {get; set;} //Navigation Property
    }
}