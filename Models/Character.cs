using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace CIDM_3312_Final_Project.Models
{
    public class Character
    {
        public int CharacterId {get; set;}	// Primary Key

        public string Class_ID {get; set;}

        [StringLength(30, MinimumLength = 3)]
        [Required]
        public string Character_Name {get; set;}

        [Range(18,65)]
        [Required]
        public int Age {get; set;}

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Background {get; set;}

        public List<Stats> Stats {get; set;} //Nav property. One character can have many stats
    }
}