

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
    }
}
