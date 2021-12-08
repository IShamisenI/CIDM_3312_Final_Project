using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CIDM_3312_Final_Project.Models;

namespace CIDM_3312_Final_Project.Pages.Characters
{
    public class DetailsModel : PageModel
    {
        private readonly CharacterContext _context;

        public DetailsModel(CharacterContext context)
        {
            _context = context;
        }

        public Character Character { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Character = await _context.Character.Include(m => m.Stats).FirstOrDefaultAsync(m => m.CharacterId == id);

            if (Character == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
