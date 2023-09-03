﻿using ClassTask.Models;
using Microsoft.EntityFrameworkCore;

namespace ClassTask.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public  DbSet<Pricing> Pricings { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<PricingService> PricingServices { get; set; }
        public DbSet<Feature> Features { get; set; }

    }
}
