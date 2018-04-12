namespace ADOnet_hw5
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Buyer> Buyers { get; set; }
        public virtual DbSet<Deal> Deals { get; set; }
        public virtual DbSet<Seller> Sellers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Buyer>()
                .Property(e => e.firstName)
                .IsUnicode(false);

            modelBuilder.Entity<Buyer>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Seller>()
                .Property(e => e.firstName)
                .IsUnicode(false);

            modelBuilder.Entity<Seller>()
                .Property(e => e.LastName)
                .IsUnicode(false);
        }
    }
}
