

namespace AuctionManagement.DomainModel.Validator
{
    using AuctionManagement.Const;
    using AuctionManagement.DataMapper;
    using FluentValidation;
    using System;
    using System.Collections.Generic;

    public class AuctionValidator : AbstractValidator<Auction>
    {
        private IConfigDataServices ConfigServices { get; set; } = DaoFactoryMethod.CurrentDAOFactory.ConfigDataServices;

       /* private IAuctionHistoryDataServices AuctionHistoryServices { get; set; } = DaoFactoryMethod.CurrentDAOFactory.AuctionHistoryDataServices;*/


        public AuctionValidator()
        {
            RuleFor(x => x.IdAuction).NotEmpty().WithErrorCode("This field is required.");
            RuleFor(x => x.ObjectId).NotEmpty().WithErrorCode("This field is required.");
            RuleFor(x => x.Currency).NotEmpty().WithErrorCode("This field is required.");
            RuleFor(x => x.Currency).Length(2, 20);
            RuleFor(x => x.StartDate).NotEmpty().WithErrorCode("This field is required.");
            RuleFor(x => x.UserId).NotEmpty().WithErrorCode("This field is required.");
            RuleFor(x => x.Price).NotEmpty().WithErrorCode("This field is required.");
        }

     

        public void InsertAuctionValidator()
        {
            RuleFor(x => x).Must(args => this.CompareDate(args.StartDate, args.EndDate)).WithErrorCode("The dates are not corect.");

            int minPrice = Configuration.GetConfigValue(ConfigServices.GetAllConfigurations(), Configuration.INITIAL_SCORE);
            RuleFor(x => x).Must(args => this.CompareStartPrice(minPrice, args.Price)).WithErrorCode("The price is too low.");
        }

    

        private bool CompareDate(DateTime startDate, DateTime endDate)
        {
            if (startDate >= endDate ||  startDate < endDate.AddMonths(-4) || startDate < DateTime.Now)
                return false;
            return true;
        }

        private bool CompareStartPrice(int minPrice, decimal price)
        {
            return price >= minPrice;
        }

      
    }
}
