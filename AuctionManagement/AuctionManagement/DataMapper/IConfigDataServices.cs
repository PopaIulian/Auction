// <copyright file="IConfigDataServices.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.DataMapper
{
    using System.Collections.Generic;
    using AuctionManagement.DomainModel;

    /// <summary>
    /// Defines the <see cref="IConfigDataServices" />.
    /// </summary>
    public interface IConfigDataServices
    {
        /// <summary>
        /// The AddConfig.
        /// </summary>
        /// <param name="config">The config<see cref="Config"/>.</param>
        void AddConfig(Config config);

        /// <summary>
        /// The GetConfigById.
        /// </summary>
        /// <param name="id">The id<see cref="string"/>.</param>
        /// <returns>The <see cref="Config"/>.</returns>
        Config GetConfigById(string id);

        /// <summary>
        /// The GetAllConfigurations.
        /// </summary>
        /// <returns>The <see cref="IList{Config}"/>.</returns>
        IList<Config> GetAllConfigurations();

        /// <summary>
        /// The UpdateConfig.
        /// </summary>
        /// <param name="config">The config<see cref="Config"/>.</param>
        void UpdateConfig(Config config);

        /// <summary>
        /// The DeleteConfig.
        /// </summary>
        /// <param name="config">The config<see cref="Config"/>.</param>
        void DeleteConfig(Config config);
    }
}
