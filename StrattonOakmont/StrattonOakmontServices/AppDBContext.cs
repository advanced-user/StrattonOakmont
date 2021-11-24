using Microsoft.EntityFrameworkCore;
using StrattonOakmontModels;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using StrattonOakmontModels.Securityes;
using StrattonOakmontModels.Securityes.Type;

namespace StrattonOakmontServices
{
    public class AppDBContext : IdentityDbContext<User>
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }
        public DbSet<Security> Securities { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Indastrial> Indastrials{ get; set; }
        public DbSet<SecurityInd> SecurityInds{ get; set; }
        public DbSet<SecuritySub> SecuritySubs{ get; set; }
        public DbSet<Bill> Bills{ get; set; }
        public DbSet<DepositReceipts> DepositReceipts{ get; set; }
        public DbSet<Stonk> Stonks{ get; set; }
        public DbSet<Abligation> Abligations{ get; set; }
        public DbSet<Forward> Forwards{ get; set; }
        public DbSet<Futures> Futures{ get; set; }
        public DbSet<Option> Options{ get; set; }
        public DbSet<Wright> Wrights{ get; set; }

    }
}
