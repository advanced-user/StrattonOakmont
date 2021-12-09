using Microsoft.EntityFrameworkCore;
using StrattonOakmontModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using StrattonOakmontModels.Securities;
using StrattonOakmontModels.Securities.Main;

namespace StrattonOakmontServices
{
    public class AppDBContext : IdentityDbContext<User>
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        public DbSet<UserStock> UserStoсks { get; set; }
        public DbSet<UserBond> UserBonds { get; set; }

        public DbSet<Security> Securities { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Stoсk> Stocks { get; set; }
        public DbSet<Bond> Bonds { get; set; }

        public DbSet<PriceСhange> PriceСhanges { get; set; }
        public DbSet<Receipt> Receipts { get; set; }
        
        public DbSet<UserStock> UserStocks { get; set; }
    }
}
