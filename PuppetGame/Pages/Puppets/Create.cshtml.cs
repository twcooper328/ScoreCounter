using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PuppetGame.Data;
using PuppetGame.Models;

namespace PuppetGame.Pages.Puppets
{
    public class CreateModel : PageModel
    {
        public int NumberTeam { get; set; }
        public int Number { get; set; }
        
        private readonly PuppetGame.Data.PuppetContext _context;

        public CreateModel(PuppetGame.Data.PuppetContext context)
        {
            _context = context;
        }

        public IActionResult OnGet(int TeamNumber)
        {
            ViewData["Number"] = TeamNumber;


            Number = TeamNumber;

            ViewData["Number2"] = Number;

            return Page();
        }

        
        

        [BindProperty]
        public Team Team { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Teams.Add(Team);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Create");
        }
    }
}
