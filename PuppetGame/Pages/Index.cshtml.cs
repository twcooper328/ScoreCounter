using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PuppetGame.Data;
using PuppetGame.Models;

namespace PuppetGame.Pages
{
    public class IndexModel : PageModel
    {
        public int NumberTeam { get; set; }
        public int Number { get; set; }
        public IList<Team> TeamList { get;set; }


        private readonly PuppetGame.Data.PuppetContext _context;

        public IndexModel(PuppetGame.Data.PuppetContext context)
        {
            _context = context;
        }

        public IActionResult OnGet(int TeamNumber)
        {
            ViewData["Number"] = TeamNumber;


            //Number = TeamNumber;

            ViewData["Number2"] = Number;

            TeamList = _context.Teams.ToList();


            int numteams = 0;

            foreach (var item in TeamList) {
                numteams++;
            };
            Number = numteams;
            ViewData["Number3"] = numteams;

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

            return RedirectToPage("./ReCreate");
        }
    }
}
