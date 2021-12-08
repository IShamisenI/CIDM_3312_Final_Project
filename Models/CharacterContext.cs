using Microsoft.EntityFrameworkCore;

namespace CIDM_3312_Final_Project.Models
{
    public class CharacterContext : DbContext
    {
        public CharacterContext (DbContextOptions<CharacterContext> options)
            : base(options)
        {
        }

        public DbSet<Character> Character {get; set;}
    }
}