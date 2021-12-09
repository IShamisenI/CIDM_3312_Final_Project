using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CIDM_3312_Final_Project.Models;
using Microsoft.Extensions.Logging;

namespace CIDM_3312_Final_Project.Pages.Characters
{
    public class AddStatsModel : PageModel
    {
        private readonly ILogger<AddStatsModel> _logger;
        private readonly CharacterContext _context; // Character Database context
        [BindProperty]
        public Stats Stats {get; set;}

        public SelectList StatsDropDown {get; set;}

        public AddStatsModel(CharacterContext context, ILogger<AddStatsModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {
            StatsDropDown = new SelectList(_context.Stats.ToList(), "Stats_Name");
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Stats.Add(Stats);
            _context.SaveChanges();

            return RedirectToPage("./Index");
        }
    }
} 