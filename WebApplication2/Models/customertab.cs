namespace WebApplication2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class customertab : DbContext
    {
        public customertab()
            : base("name=customertab")
        {
        }

        public virtual DbSet<customertable> customertables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<customertable>()
                .Property(e => e.CustomerID)
                .IsUnicode(false);

            modelBuilder.Entity<customertable>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<customertable>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<customertable>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<customertable>()
                .Property(e => e.Email)
                .IsUnicode(false);
        }
    }
}
