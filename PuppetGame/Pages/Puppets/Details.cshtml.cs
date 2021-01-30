using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PuppetGame.Data;
using PuppetGame.Models;

namespace PuppetGame.Pages.Puppets
{
    public class DetailsModel : PageModel
    {
        private readonly PuppetGame.Data.PuppetContext _context;

        public DetailsModel(PuppetGame.Data.PuppetContext context)
        {
            _context = context;
        }

        public Hat Hat { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Hat = await _context.Hats.FirstOrDefaultAsync(m => m.HatID == id);

            if (Hat == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
