// <copyright file="Model1.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.DomainModel
{
    using System.Data.Entity;

    /// <summary>
    /// Defines the <see cref="AppContext" />.
    /// </summary>
    public partial class AppContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppContext"/> class.
        /// </summary>
        public AppContext()
            : base("name=Model2")
        {
        }

        /// <summary>
        /// Gets or sets the Auctions.
        /// </summary>
        public virtual DbSet<Auction> Auctions { get; set; }

        /// <summary>
        /// Gets or sets the AuctionHistories.
        /// </summary>
        public virtual DbSet<AuctionHistory> AuctionHistories { get; set; }

        /// <summary>
        /// Gets or sets the Categories.
        /// </summary>
        public virtual DbSet<Category> Categories { get; set; }

        /// <summary>
        /// Gets or sets the CategoryParents.
        /// </summary>
        public virtual DbSet<CategoryParent> CategoryParents { get; set; }

        /// <summary>
        /// Gets or sets the Configurations.
        /// </summary>
        public virtual DbSet<Config> Configs { get; set; }

        /// <summary>
        /// Gets or sets the People.
        /// </summary>
        public virtual DbSet<Person> People { get; set; }

        /// <summary>
        /// Gets or sets the Products.
        /// </summary>
        public virtual DbSet<Product> Products { get; set; }

        /// <summary>
        /// Gets or sets the ScoreHistories.
        /// </summary>
        public virtual DbSet<ScoreHistory> ScoreHistories { get; set; }

        /// <summary>
        /// Gets or sets the system diagrams.
        /// </summary>
        public virtual DbSet<Sysdiagram> Sysdiagrams { get; set; }

        /// <summary>
        /// The OnModelCreating.
        /// </summary>
        /// <param name="modelBuilder">The modelBuilder<see cref="DbModelBuilder"/>.</param>
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
                .HasForeignKey(e => e.CategoryId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.CategoryParents1)
                .WithRequired(e => e.Category1)
                .HasForeignKey(e => e.ParentId)
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
