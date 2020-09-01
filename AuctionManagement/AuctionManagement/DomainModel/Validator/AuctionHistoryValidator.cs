// <copyright file="AuctionHistoryValidator.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.DomainModel.Validator
{
    using FluentValidation;

    /// <summary>
    /// Defines the <see cref="AuctionHistoryValidator" />.
    /// </summary>
    public class AuctionHistoryValidator : AbstractValidator<AuctionHistory>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuctionHistoryValidator"/> class.
        /// </summary>
        public AuctionHistoryValidator()
        {
            RuleFor(x => x.IdAuctionHistory).NotEmpty().WithErrorCode("Id  field is required.");
            RuleFor(x => x.AuctionId).NotEmpty().WithErrorCode("Auction id field is required.");
            RuleFor(x => x.UserId).NotEmpty().WithErrorCode("User id field is required.");
            RuleFor(x => x.AuctionDate).NotEmpty().WithErrorCode("Auction data field is required.");
            RuleFor(x => x.Price).NotEmpty().WithErrorCode("Price field is required.");
        }

        /// <summary>
        /// The InsertAuctionHistoryValidator.
        /// </summary>
        /// <param name="lastModify">The lastModify<see cref="AuctionHistory"/>.</param>
        public void InsertAuctionHistoryValidator(AuctionHistory lastModify)
        {
            RuleFor(x => x).Must(args => this.CompareNewPrice(lastModify.Price, args.Price)).WithErrorCode("The price is not ok.");
            RuleFor(x => x.Currency).Equal(lastModify.Currency).WithErrorCode("The currency is different.");
        }

        /// <summary>
        /// The CompareNewPrice.
        /// </summary>
        /// <param name="oldPrice">The oldPrice<see cref="double"/>.</param>
        /// <param name="newPrice">The newPrice<see cref="double"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        private bool CompareNewPrice(double oldPrice, double newPrice)
        {
            return oldPrice > newPrice && (newPrice - oldPrice) > (oldPrice / 10);
        }
    }
}
