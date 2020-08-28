

namespace AuctionManagement.DomainModel.Validator
{
    using FluentValidation;


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
    }
}
