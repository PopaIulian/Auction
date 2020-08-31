namespace AuctionManagement.DomainModel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=AppContext")
        {
        }

        public virtual DbSet<Auction> Auctions { get; set; }
        public virtual DbSet<AuctionHistory> AuctionHistories { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CategoryParent> CategoryParents { get; set; }
        public virtual DbSet<Config> Configs { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ScoreHistory> ScoreHistories { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Auction>()
                .Property(e => e.Currency)
                .IsUnicode(false);

            modelBuilder.Entity<Auction>()
                .Property(e => e.Price)
                .HasPrecision(8, 2);

            modelBuilder.Entity<Auction>()
                .HasMany(e => e.AuctionHistories)
                .WithRequired(e => e.Auction)
                .HasForeignKey(e => e.AuctionId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AuctionHistory>()
                .Property(e => e.Currency)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.CategoryName)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.CategoryParents)
                .WithRequired(e => e.Category)
                .HasForeignKey(e => e.categoryId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.CategoryParents1)
                .WithRequired(e => e.Category1)
                .HasForeignKey(e => e.parentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Products)
                .WithOptional(e => e.Category)
                .HasForeignKey(e => e.CategoryName);

            modelBuilder.Entity<Config>()
                .Property(e => e.IdConfig)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.PersonRole)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.Auctions)
                .WithRequired(e => e.Person)
                .HasForeignKey(e => e.UserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.AuctionHistories)
                .WithRequired(e => e.Person)
                .HasForeignKey(e => e.UserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.ScoreHistories)
                .WithRequired(e => e.Person)
                .HasForeignKey(e => e.PersonId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.ObjectName)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Auctions)
                .WithRequired(e => e.Product)
                .HasForeignKey(e => e.ObjectId)
                .WillCascadeOnDelete(false);
        }
    }
}
