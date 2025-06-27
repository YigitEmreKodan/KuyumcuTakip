using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KuyumcuTakip.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<KuyumcuTakip.Models.Product> Products { get; set; }
        public DbSet<KuyumcuTakip.Models.Transaction> Transactions { get; set; }
    }
}
