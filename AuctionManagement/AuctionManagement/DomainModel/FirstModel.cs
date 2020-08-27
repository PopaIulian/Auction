namespace AuctionManagement.DomainModel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FirstModel : DbContext
    {
        public FirstModel()
            : base("name=FirstModel")
        {
        }

        public virtual DbSet<Auction> Auctions { get; set; }
        public virtual DbSet<AuctionHistory> AuctionHistories { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Config> Configs { get; set; }
        public virtual DbSet<Object> Objects { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Auction>()
                .Property(e => e.currency)
                .IsUnicode(false);

            modelBuilder.Entity<Auction>()
                .Property(e => e.price)
                .HasPrecision(8, 2);

            modelBuilder.Entity<Auction>()
                .HasMany(e => e.AuctionHistories)
                .WithOptional(e => e.Auction)
                .HasForeignKey(e => e.auctionId);

            modelBuilder.Entity<Category>()
                .Property(e => e.categoryName)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Category1)
                .WithOptional(e => e.Category2)
                .HasForeignKey(e => e.parentId);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Objects)
                .WithOptional(e => e.Category)
                .HasForeignKey(e => e.categoryName);

            modelBuilder.Entity<Config>()
                .Property(e => e.idConfig)
                .IsUnicode(false);

            modelBuilder.Entity<Object>()
                .Property(e => e.objectName)
                .IsUnicode(false);

            modelBuilder.Entity<Object>()
                .HasMany(e => e.Auctions)
                .WithRequired(e => e.Object)
                .HasForeignKey(e => e.objectId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.personRole)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.Auctions)
                .WithRequired(e => e.Person)
                .HasForeignKey(e => e.userId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.AuctionHistories)
                .WithOptional(e => e.Person)
                .HasForeignKey(e => e.userId);
        }
    }
}
