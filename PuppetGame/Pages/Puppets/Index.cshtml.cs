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
    public class IndexModel : PageModel
    {
        private readonly PuppetGame.Data.PuppetContext _context;

        public IndexModel(PuppetGame.Data.PuppetContext context)
        {
            _context = context;
        }

        public IList<Hat> Hat { get;set; }

        public async Task OnGetAsync()
        {
            Hat = await _context.Hats.ToListAsync();
        }
    }
}
