using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Owner>().Property(ww => ww.ID).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<PortofolioItems>().Property(ww => ww.ID).HasDefaultValueSql("NEWID()");

           

            modelBuilder.Entity<Owner>().HasData(
                new Owner
                {
                    ID = Guid.NewGuid(),
                    FullName = "Abobakr Mohammed",
                    Position = "FullSatck Web Developer",
                    Avatar = "user.png"
                    
                }) ;
           

        }

        public DbSet<Owner> owners { get; set; }
        public DbSet<PortofolioItems> portofolioItems { get; set; }

    }
}
