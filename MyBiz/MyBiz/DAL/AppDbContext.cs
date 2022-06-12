using Microsoft.EntityFrameworkCore;
using MyBiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBiz.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<Sliders> Sliders { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<PortfolioCategory> PortfolioCategories { get; set; }
    }
}
