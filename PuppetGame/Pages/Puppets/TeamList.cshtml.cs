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
    public class TeamListModel : PageModel
    {
        private readonly PuppetGame.Data.PuppetContext _context;

        public TeamListModel(PuppetGame.Data.PuppetContext context)
        {
            _context = context;
        }

        public IList<Team> Team { get;set; }

        public async Task OnGetAsync()
        {
            Team = await _context.Teams.ToListAsync();
        }
    }
}
