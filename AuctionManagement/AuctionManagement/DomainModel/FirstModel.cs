// <copyright file="FirstModel.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.DomainModel
{
    using System.Data.Entity;

    /// <summary>
    /// Defines the <see cref="FirstModel" />.
    /// </summary>
    public partial class FirstModel : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FirstModel"/> class.
        /// </summary>
        public FirstModel()
            : base("name=FirstModel")
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
        /// Gets or sets the Objects.
        /// </summary>
        public virtual DbSet<Object> Objects { get; set; }

        /// <summary>
        /// Gets or sets the People.
        /// </summary>
        public virtual DbSet<Person> People { get; set; }

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
