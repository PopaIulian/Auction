// <copyright file="ConfigServices.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.Services.ServicesImplementation
{
    using System.Collections.Generic;
    using AuctionManagement.DataMapper;
    using AuctionManagement.DomainModel;
    using AuctionManagement.DomainModel.Validator;
    using FluentValidation.Results;

    /// <summary>
    /// Defines the <see cref="ConfigServices" />.
    /// </summary>
    internal class ConfigServices : IConfigServices
    {
        /// <summary>
        /// Defines the Log.
        /// </summary>
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(ConfigServices));

        /// <summary>
        /// Gets or sets the DataServices.
        /// </summary>
        public static IConfigDataServices DataServices { get; set; } = DaoFactoryMethod.CurrentDAOFactory.ConfigDataServices;

        /// <summary>
        /// The AddConfig.
        /// </summary>
        /// <param name="config">The config<see cref="Config"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool AddConfig(Config config)
        {
            var validator = new ConfigValidator();
            ValidationResult results = validator.Validate(config);

            bool isValid = results.IsValid;

            if (isValid)
            {
                Log.Info("The config is valid!");
                DataServices.AddConfig(config);
                Log.Info("The config was updated to the database!");
            }
            else
            {
                IList<ValidationFailure> failures = results.Errors;
                Log.Error($"The config is not valid. The following errors occurred: {failures}");
            }

            return isValid;
        }

        /// <summary>
        /// The DeleteConfig.
        /// </summary>
        /// <param name="config">The config<see cref="Config"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool DeleteConfig(Config config)
        {
            var validator = new ConfigValidator();
            ValidationResult results = validator.Validate(config);

            bool isValid = results.IsValid;

            if (isValid)
            {
                Log.Info("The config is valid!");
                DataServices.DeleteConfig(config);
                Log.Info("The config was updated to the database!");
            }
            else
            {
                IList<ValidationFailure> failures = results.Errors;
                Log.Error($"The config is not valid. The following errors occurred: {failures}");
            }

            return isValid;
        }

        /// <summary>
        /// The GetConfigById.
        /// </summary>
        /// <param name="id">The id<see cref="string"/>.</param>
        /// <returns>The <see cref="Config"/>.</returns>
        public Config GetConfigById(string id)
        {
            return DataServices.GetConfigById(id);
        }

        /// <summary>
        /// The GetListOfConfigurations.
        /// </summary>
        /// <returns>The <see cref="IList{Config}"/>.</returns>
        public IList<Config> GetListOfConfigurations()
        {
            return DataServices.GetAllConfigurations();
        }

        /// <summary>
        /// The UpdateConfig.
        /// </summary>
        /// <param name="config">The config<see cref="Config"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool UpdateConfig(Config config)
        {
            var validator = new ConfigValidator();
            ValidationResult results = validator.Validate(config);

            bool isValid = results.IsValid;

            if (isValid)
            {
                Log.Info("The config is valid!");
                DataServices.UpdateConfig(config);
                Log.Info("The config was updated to the database!");
            }
            else
            {
                IList<ValidationFailure> failures = results.Errors;
                Log.Error($"The config is not valid. The following errors occurred: {failures}");
            }

            return isValid;
        }
    }
}
