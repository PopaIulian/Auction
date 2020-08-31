// <copyright file="AuctionHistoryServices.cs" company="Transilvania University of Brasov">
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
    /// Defines the <see cref="AuctionHistoryServices" />.
    /// </summary>
    internal class AuctionHistoryServices : IAuctionHistoryServices
    {
        /// <summary>
        /// Defines the Log.
        /// </summary>
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(AuctionServices));

        /// <summary>
        /// Gets or sets the DataServices.
        /// </summary>
        public static IAuctionHistoryDataServices DataServices { get; set; } = DaoFactoryMethod.CurrentDAOFactory.AuctionHistoryDataServices;

        /// <summary>
        /// The AddAuctionHistory.
        /// </summary>
        /// <param name="auctionHistory">The auctionHistory<see cref="AuctionHistory"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool AddAuctionHistory(AuctionHistory auctionHistory)
        {
            var validator = new AuctionHistoryValidator();
            validator.InsertAuctionHistoryValidator(DataServices.GetLastAuctionInfo(auctionHistory.AuctionId));
            ValidationResult results = validator.Validate(auctionHistory);

            bool isValid = results.IsValid;

            if (isValid)
            {
                Log.Info("The auction is valid!");
                DataServices.AddAuctionHistory(auctionHistory);
                Log.Info("The auction history was added to the database!");
            }
            else
            {
                IList<ValidationFailure> failures = results.Errors;
                Log.Error($"The auction history  is not valid. The following errors occurred: {failures}");
            }

            return isValid;
        }

        /// <summary>
        /// The DeleteAuctionHistory.
        /// </summary>
        /// <param name="auctionHistory">The auctionHistory<see cref="AuctionHistory"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool DeleteAuctionHistory(AuctionHistory auctionHistory)
        {
            var validator = new AuctionHistoryValidator();
            ValidationResult results = validator.Validate(auctionHistory);

            bool isValid = results.IsValid;

            if (isValid)
            {
                Log.Info("The auction is valid!");
                DataServices.DeleteAuctionHistory(auctionHistory);
                Log.Info("The auction history was deleted to the database!");
            }
            else
            {
                IList<ValidationFailure> failures = results.Errors;
                Log.Error($"The auction history is not valid. The following errors occurred: {failures}");
            }

            return isValid;
        }

        /// <summary>
        /// The GetAuctionHistoryById.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="AuctionHistory"/>.</returns>
        public AuctionHistory GetAuctionHistoryById(int id)
        {
            return DataServices.GetAuctionHistoryById(id);
        }

        /// <summary>
        /// The GetLastAuctionInfo.
        /// </summary>
        /// <param name="auctionId">The auctionId<see cref="int"/>.</param>
        /// <returns>The <see cref="AuctionHistory"/>.</returns>
        public AuctionHistory GetLastAuctionInfo(int auctionId)
        {
            return DataServices.GetLastAuctionInfo(auctionId);
        }

        /// <summary>
        /// The GetListOfAuctionHistory.
        /// </summary>
        /// <returns>The <see cref="IList{AuctionHistory}"/>.</returns>
        public IList<AuctionHistory> GetListOfAuctionHistory()
        {
            return DataServices.GetAllAuctionsHistory();
        }

        /// <summary>
        /// The UpdateAuctionHistory.
        /// </summary>
        /// <param name="auctionHistory">The auctionHistory<see cref="AuctionHistory"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool UpdateAuctionHistory(AuctionHistory auctionHistory)
        {
            var validator = new AuctionHistoryValidator();
            ValidationResult results = validator.Validate(auctionHistory);

            bool isValid = results.IsValid;

            if (isValid)
            {
                Log.Info("The auction is valid!");
                DataServices.UpdateAuctionHistory(auctionHistory);
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
