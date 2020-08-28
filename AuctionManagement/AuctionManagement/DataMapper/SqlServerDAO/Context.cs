
namespace AuctionManagement.DataMapper.SqlServerDAO
{
    using System.Data.Entity;
    using AuctionManagement.DomainModel;

    class Context : DbContext
    {
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(Context));

        public Context() : base("connString")
        {
            Log.Info("ApplicationContext instance created!");
        }
        public DbSet<Auction> Auctions { get; set; }

        public DbSet<AuctionHistory> AuctionsHistory { get; set; }

        public DbSet<Config> Configs { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Person> Persons { get; set; }

        public DbSet<ScoreHistory> ScoreHistories { get; set; }
    }
}
