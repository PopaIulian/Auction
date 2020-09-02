// <copyright file="IConfigServices.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.Services
{
    using System.Collections.Generic;
    using AuctionManagement.DomainModel;

    /// <summary>
    /// Defines the <see cref="IConfigServices" />.
    /// </summary>
    public interface IConfigServices
    {
        /// <summary>
        /// The AddConfig.
        /// </summary>
        /// <param name="config">The config<see cref="Config"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        bool AddConfig(Config config);

        /// <summary>
        /// The GetConfigById.
        /// </summary>
        /// <param name="id">The id<see cref="string"/>.</param>
        /// <returns>The <see cref="Config"/>.</returns>
        Config GetConfigById(string id);

        /// <summary>
        /// The GetListOfConfigurations.
        /// </summary>
        /// <returns>The <see cref="IList{Config}"/>.</returns>
        IList<Config> GetListOfConfigurations();

        /// <summary>
        /// The UpdateConfig.
        /// </summary>
        /// <param name="config">The config<see cref="Config"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        bool UpdateConfig(Config config);

        /// <summary>
        /// The DeleteConfig.
        /// </summary>
        /// <param name="config">The config<see cref="Config"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        bool DeleteConfig(Config config);
    }
}
