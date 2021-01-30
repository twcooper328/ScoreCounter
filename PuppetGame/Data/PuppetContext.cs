using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PuppetGame.Models;

namespace PuppetGame.Data
{
    public class PuppetContext : DbContext
    {
        public PuppetContext (DbContextOptions<PuppetContext> options)
            : base(options)
        {
        }

    
        public DbSet<Hat> Hats { get; set; }
        public DbSet<Eye> Eyes { get; set; }
        public DbSet<Arm> Arms { get; set; }
        public DbSet<Leg> Legs { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Turn> Turns { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hat>().ToTable("Hat");
            modelBuilder.Entity<Eye>().ToTable("Eye");
            modelBuilder.Entity<Arm>().ToTable("Arm");
            modelBuilder.Entity<Leg>().ToTable("Leg");
            modelBuilder.Entity<Team>().ToTable("Team");
        }
    }
}
