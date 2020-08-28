
namespace AuctionManagement.Services.ServicesImplementation
{
    using System;
    using System.Collections.Generic;
    using AuctionManagement.DataMapper;
    using AuctionManagement.DomainModel;
    using AuctionManagement.DomainModel.Validator;
    using FluentValidation.Results;

    class AuctionServices : IAuctionServices
    {
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(AuctionServices));

        /// <summary>Gets or sets the data services.</summary>
        public static IAuctionDataServices DataServices { get; set; } = DaoFactoryMethod.CurrentDAOFactory.AuctionDataServices;

        public bool AddAuction(Auction auction)
        {
            var validator = new AuctionValidator();
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

        public bool DeleteAuction(Auction auction)
        {
            throw new NotImplementedException();
        }

        public Auction GetAuctionById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Auction> GetListOfAuctions()
        {
            throw new NotImplementedException();
        }

        public bool UpdateAuction(Auction auction)
        {
            throw new NotImplementedException();
        }
    }
}
