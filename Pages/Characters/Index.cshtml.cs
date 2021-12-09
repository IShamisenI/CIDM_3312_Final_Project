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
    public class IndexModel : PageModel
    {
        private readonly CharacterContext _context;

        public IndexModel(CharacterContext context)
        {
            _context = context;
        }

        public IList<Character> Character { get;set; }

        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} = 10;

        [BindProperty(SupportsGet = true)]
        public string CurrentSort {get; set;}
        public async Task OnGetAsync()
        {
            var query = _context.Character.Select(c => c);

            switch (CurrentSort)
            {
                case "first_asc":
                    query = query.OrderBy(c => c.Character_Name);
                    break;
                case "first_desc":
                    query = query.OrderByDescending(c => c.Character_Name);
                    break;
            }

            Character = await query.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
        }
    }
}
