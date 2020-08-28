using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuctionManagement.DataMapper;
using AuctionManagement.DomainModel;
using AuctionManagement.DomainModel.Validator;
using FluentValidation.Results;

namespace AuctionManagement.Services.ServicesImplementation
{
    class AuctionHistoryServices : IAuctionHistoryServices
    {
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(AuctionServices));
        public static IAuctionHistoryDataServices DataServices { get; set; } = DaoFactoryMethod.CurrentDAOFactory.AuctionHistoryDataServices;


        public bool AddAuctionHistory(AuctionHistory auctionHistory)
        {
            var validator = new AuctionHistoryValidator();
            validator.InsertAuctionHistoryValidator(DataServices.GetLastAuctionInfo(auctionHistory.AuctionId).Price);
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

        public AuctionHistory GetAuctionHistoryById(int id)
        {
            return DataServices.GetAuctionHistoryById(id);
        }

        public AuctionHistory GetLastAuctionInfo(int auctionId)
        {
            return DataServices.GetLastAuctionInfo(auctionId);
        }

        public IList<AuctionHistory> GetListOfAuctionHistory()
        {
            return DataServices.GettAllAuctionsHistory();
        }

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
