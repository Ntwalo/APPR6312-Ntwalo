using Ntwalo_APPR6312.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Ntwalo_APPR6312.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<DonationItem> DonationsItems { get; set; }

        public DbSet<DonationMoney> DonationsMoney { get; set; }

        public DbSet<Disaster> Disasters { get; set; }

        public DbSet<Catagory> Catagories { get; set; }
    }
}
