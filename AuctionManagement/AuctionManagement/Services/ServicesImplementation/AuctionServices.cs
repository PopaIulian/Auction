﻿
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
            validator.InsertAuctionValidator();
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

        public Auction GetAuctionById(int id)
        {
            return DataServices.GetAuctionById(id);
        }

        public IList<Auction> GetListOfAuctions()
        {
            return DataServices.GetAllAuctions();
        }

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
