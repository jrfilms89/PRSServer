using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PRSServer.Models;

namespace PRSServer.Data
{
    public class PRSServerContext : DbContext
    {
        public PRSServerContext (DbContextOptions<PRSServerContext> options)
            : base(options)
        {
        }

        public DbSet<PRSServer.Models.User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<User>(e => {
                e.HasIndex("Username").IsUnique();
            });
            modelBuilder.Entity<Vendor>(e => {
                e.HasIndex("Code").IsUnique();
            });
            modelBuilder.Entity<Product>(e => {
                e.HasIndex("PartNbr").IsUnique();
            });
        }

        public DbSet<PRSServer.Models.Vendor> Vendor { get; set; }

        public DbSet<PRSServer.Models.Product> Product { get; set; }

        public DbSet<PRSServer.Models.Request> Request { get; set; }

        public DbSet<PRSServer.Models.Requestline> Requestline { get; set; }
    }
}
