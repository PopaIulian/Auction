

namespace AuctionManagement.DomainModel.Validator
{
    using AuctionManagement.Const;
    using FluentValidation;
    using FluentValidation.Results;
    using System;
    using System.Collections.Generic;

    public class AuctionValidator : AbstractValidator<Auction>
    {
        /// <summary>Initializes a new instance of the <see cref="PublishingHouseValidator"/> class.</summary>
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

     

        public void AddAuctionValidator(IList<Config> configuration)
        {
            RuleFor(x => x).Must(args => this.CompareDate(args.StartDate, args.EndDate)).WithErrorCode("The dates are not corect.");
            int minPrice = Configuration.GetConfigValue(configuration, Configuration.INITIAL_SCORE);
            RuleFor(x => x).Must(args => this.CompareStartPrice(minPrice, args.Price)).WithErrorCode("The price is too low.");


        }

        bool CompareDate(DateTime startDate, DateTime endDate)
        {
            if (startDate >= endDate ||  startDate < endDate.AddMonths(-4) || startDate < DateTime.Now)
                return false;
            return true;
        }

        bool CompareStartPrice(int minPrice, decimal price)
        {
            return price >= minPrice;
        }

    }
}
