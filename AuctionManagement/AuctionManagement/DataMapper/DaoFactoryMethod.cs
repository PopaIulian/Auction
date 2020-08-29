// <copyright file="DaoFactoryMethod.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.DataMapper
{
    using AuctionManagement.DataMapper.SqlServerDAO;

    /// <summary>
    /// Defines the <see cref="DaoFactoryMethod" />.
    /// </summary>
    internal class DaoFactoryMethod
    {
        /// <summary>
        /// Gets the CurrentDAOFactory.
        /// </summary>
        public static IDaoFactory CurrentDAOFactory
        {
            get
            {
                return new SqlServerDaoFactory();
            }
        }
    }
}
