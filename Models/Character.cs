using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CIDM_3312_Final_Project.Models
{
    public class Character
    {
        public int CharacterId {get; set;}	// Primary Key

        public string Class_ID {get; set;}

        [StringLength(30, MinimumLength = 3)]
        [Required]
        public string Character_Name {get; set;}
        public int Age {get; set;}

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Background {get; set;}
    }
}