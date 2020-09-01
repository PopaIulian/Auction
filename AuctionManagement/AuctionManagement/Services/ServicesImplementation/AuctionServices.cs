// <copyright file="AuctionServices.cs" company="Transilvania University of Brasov">
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
    /// Defines the <see cref="AuctionServices" />.
    /// </summary>
    internal class AuctionServices : IAuctionServices
    {
        /// <summary>
        /// Defines the Log.
        /// </summary>
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(AuctionServices));

        /// <summary>
        /// Gets or sets the DataServices.
        /// </summary>
        public static IAuctionDataServices DataServices { get; set; } = DaoFactoryMethod.CurrentDAOFactory.AuctionDataServices;

        /// <summary>
        /// The AddAuction.
        /// </summary>
        /// <param name="auction">The auction<see cref="Auction"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool AddAuction(Auction auction)
        {
            var validator = new AuctionValidator();
            validator.InsertAuctionValidator(DataServices.GetAllOpenAuction(auction.UserId));
            ValidationResult results = validator.Validate(auction);

            bool isValid = results.IsValid;

            if (isValid)
            {
                Log.Info("The auction is valid!");
                DataServices.AddAuction(auction);
                Log.Info("The auction was added to the database!");
            }
            else
            {
                IList<ValidationFailure> failures = results.Errors;
                Log.Error($"The auction is not valid. The following errors occurred: {failures}");
            }

            return isValid;
        }

        /// <summary>
        /// The DeleteAuction.
        /// </summary>
        /// <param name="auction">The auction<see cref="Auction"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool DeleteAuction(Auction auction)
        {
            var validator = new AuctionValidator();
            ValidationResult results = validator.Validate(auction);

            bool isValid = results.IsValid;

            if (isValid)
            {
                Log.Info("The auction is valid!");
                DataServices.DeleteAuction(auction);
                Log.Info("The auction was deleted to the database!");
            }
            else
            {
                IList<ValidationFailure> failures = results.Errors;
                Log.Error($"The auction is not valid. The following errors occurred: {failures}");
            }

            return isValid;
        }

        /// <summary>
        /// The GetAuctionById.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="Auction"/>.</returns>
        public Auction GetAuctionById(int id)
        {
            return DataServices.GetAuctionById(id);
        }

        /// <summary>
        /// The GetListOfAuctions.
        /// </summary>
        /// <returns>The <see cref="IList{Auction}"/>.</returns>
        public IList<Auction> GetListOfAuctions()
        {
            return DataServices.GetAllAuctions();
        }

        /// <summary>
        /// The UpdateAuction.
        /// </summary>
        /// <param name="auction">The auction<see cref="Auction"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool UpdateAuction(Auction auction)
        {
            var validator = new AuctionValidator();
            ValidationResult results = validator.Validate(auction);

            bool isValid = results.IsValid;

            if (isValid)
            {
                Log.Info("The auction is valid!");
                DataServices.UpdateAuction(auction);
                Log.Info("The auction was updated to the database!");
            }
            else
            {
                IList<ValidationFailure> failures = results.Errors;
                Log.Error($"The auction is not valid. The following errors occurred: {failures}");
            }

            return isValid;
        }
    }
}
