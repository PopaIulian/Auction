// <copyright file="Model1.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.DomainModel
{
    using System.Data.Entity;

    /// <summary>
    /// Defines the <see cref="Model1" />.
    /// </summary>
    public  class Model1 : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Model1"/> class.
        /// </summary>
        public Model1()
            : base("Model1")
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
        /// Gets or sets the Configs.
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
        /// Gets or sets the sysdiagrams.
        /// </summary>
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

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
                .HasMany(e => e.Category1)
                .WithOptional(e => e.Category2)
                .HasForeignKey(e => e.ParentId);

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
