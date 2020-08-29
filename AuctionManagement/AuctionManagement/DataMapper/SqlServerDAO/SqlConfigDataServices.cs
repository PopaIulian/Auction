﻿// <copyright file="SqlConfigDataServices.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.DataMapper.SqlServerDAO
{
    using System.Collections.Generic;
    using System.Linq;
    using AuctionManagement.DomainModel;

    /// <summary>
    /// Defines the <see cref="SqlConfigDataServices" />.
    /// </summary>
    internal class SqlConfigDataServices : IConfigDataServices
    {
        /// <summary>
        /// The AddConfig.
        /// </summary>
        /// <param name="config">The config<see cref="Config"/>.</param>
        public void AddConfig(Config config)
        {
            using (Model1 context = new Model1())
            {
                context.Configs.Add(config);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// The DeleteConfig.
        /// </summary>
        /// <param name="config">The config<see cref="Config"/>.</param>
        public void DeleteConfig(Config config)
        {
            using (Context context = new Context())
            {
                Config toBeDeleted = new Config { IdConfig = config.IdConfig };
                context.Configurations.Attach(toBeDeleted);
                context.Configurations.Remove(toBeDeleted);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// The GetConfigById.
        /// </summary>
        /// <param name="id">The id<see cref="string"/>.</param>
        /// <returns>The <see cref="Config"/>.</returns>
        public Config GetConfigById(string id)
        {
            using (Context context = new Context())
            {
                return context.Configurations.Where(config => config.IdConfig == id).SingleOrDefault();
            }
        }

        /// <summary>
        /// The GetAllConfigurations.
        /// </summary>
        /// <returns>The <see cref="IList{Config}"/>.</returns>
        public IList<Config> GetAllConfigurations()
        {
            using (Model1 context = new Model1())
            {
                var res =  context.Configs.Select(config => config).ToList();
                return res;
            }
        }

        /// <summary>
        /// The UpdateConfig.
        /// </summary>
        /// <param name="config">The config<see cref="Config"/>.</param>
        public void UpdateConfig(Config config)
        {
            using (Context context = new Context())
            {
                Config toBeUpdated = context.Configurations.Find(config.IdConfig);

                if (toBeUpdated != null)
                {
                    context.Entry(toBeUpdated).CurrentValues.SetValues(config);
                    context.SaveChanges();
                }
            }
        }
    }
}
