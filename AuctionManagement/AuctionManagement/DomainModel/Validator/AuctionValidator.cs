// <copyright file="AuctionValidator.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.DomainModel.Validator
{
    using System;
    using AuctionManagement.Const;
    using AuctionManagement.DataMapper;
    using FluentValidation;

    /// <summary>
    /// Defines the <see cref="AuctionValidator" />.
    /// </summary>
    public class AuctionValidator : AbstractValidator<Auction>
    {
        /// <summary>
        /// Gets or sets the ConfigServices.
        /// </summary>
        private IConfigDataServices ConfigServices { get; set; } = DaoFactoryMethod.CurrentDAOFactory.ConfigDataServices;

        /* private IAuctionHistoryDataServices AuctionHistoryServices { get; set; } = DaoFactoryMethod.CurrentDAOFactory.AuctionHistoryDataServices;*/
        /// <summary>
        /// Initializes a new instance of the <see cref="AuctionValidator"/> class.
        /// </summary>
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

        /// <summary>
        /// The InsertAuctionValidator.
        /// </summary>
        public void InsertAuctionValidator()
        {
            RuleFor(x => x).Must(args => this.CompareDate(args.StartDate, args.EndDate)).WithErrorCode("The dates are not corect.");

            int minPrice = Configuration.GetConfigValue(ConfigServices.GetAllConfigurations(), Configuration.INITIAL_SCORE);
            RuleFor(x => x).Must(args => this.CompareStartPrice(minPrice, args.Price)).WithErrorCode("The price is too low.");
        }

        /// <summary>
        /// The CompareDate.
        /// </summary>
        /// <param name="startDate">The startDate<see cref="DateTime"/>.</param>
        /// <param name="endDate">The endDate<see cref="DateTime"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        private bool CompareDate(DateTime startDate, DateTime endDate)
        {
            if (startDate >= endDate || startDate < endDate.AddMonths(-4) || startDate < DateTime.Now)
                return false;
            return true;
        }

        /// <summary>
        /// The CompareStartPrice.
        /// </summary>
        /// <param name="minPrice">The minPrice<see cref="int"/>.</param>
        /// <param name="price">The price<see cref="decimal"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        private bool CompareStartPrice(int minPrice, decimal price)
        {
            return price >= minPrice;
        }
    }
}
