using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BabichevWebSite.Data
{
    public class BabichevDbContext:DbContext
    {
        DbContextOptions<BabichevDbContext> _options;
        public DbSet<UserProfiles> UserProfiles { get; set; }

        public BabichevDbContext(DbContextOptions<BabichevDbContext> options):base(options)
        {
            _options = options;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
         
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("Server=BABICHEVBORBA\\BORBA;Database=Babichev;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
           
        }
    }
}
