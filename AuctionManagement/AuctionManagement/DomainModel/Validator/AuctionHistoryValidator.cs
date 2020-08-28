

namespace AuctionManagement.DomainModel.Validator
{
    using FluentValidation;

    public class AuctionHistoryValidator : AbstractValidator<AuctionHistory>
    {
        /// <summary>Initializes a new instance of the <see cref="PublishingHouseValidator"/> class.</summary>
        public AuctionHistoryValidator()
        {
            RuleFor(x => x.IdAuctionHistory).NotEmpty().WithErrorCode("This field is required.");
            RuleFor(x => x.AuctionId).NotEmpty().WithErrorCode("This field is required.");
            RuleFor(x => x.UserId).NotEmpty().WithErrorCode("This field is required.");
            RuleFor(x => x.Auctiondate).NotEmpty().WithErrorCode("This field is required.");
            RuleFor(x => x.Price).NotEmpty().WithErrorCode("This field is required.");
        }

        public void InsertAuctionHistoryValidator(AuctionHistory lastModify)
        {
            RuleFor(x => x).Must(args => this.CompareNewPrice(lastModify.Price, args.Price)).WithErrorCode("The price is not ok.");
            RuleFor(x => x.Currency).Equal(lastModify.Currency).WithErrorCode("The currency is different.");
            
        }

        private bool CompareNewPrice(double oldPrice, double newPrice)
        {
            if (oldPrice > newPrice || (newPrice - oldPrice) > (oldPrice / 10))
                return false;
            return true;
        }
    }
}
