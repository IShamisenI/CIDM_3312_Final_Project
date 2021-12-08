using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CIDM_3312_Final_Project.Models;

    public class RazorPagesCharacterContext : DbContext
    {
        public RazorPagesCharacterContext (DbContextOptions<RazorPagesCharacterContext> options)
            : base(options)
        {
        }

        public DbSet<CIDM_3312_Final_Project.Models.Character> Character { get; set; }
    }
