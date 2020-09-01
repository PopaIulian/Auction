// <copyright file="AuctionValidator.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.DomainModel.Validator
{
    using AuctionManagement.Const;
    using AuctionManagement.DataMapper;
    using FluentValidation;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="AuctionValidator" />.
    /// </summary>
    public class AuctionValidator : AbstractValidator<Auction>
    {
        /// <summary>
        /// Gets or sets the ConfigServices.
        /// </summary>
        private IConfigDataServices ConfigServices { get; set; } = DaoFactoryMethod.CurrentDAOFactory.ConfigDataServices;

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
        /// <param name="allOpenedAuction">The allOpenedAuction<see cref="IList{Auction}"/>.</param>
        public void InsertAuctionValidator(IList<Auction> allOpenedAuction)
        {
            var configurations = ConfigServices.GetAllConfigurations();
            RuleFor(x => x).Must(args => this.CompareDate(args.StartDate, args.EndDate)).WithErrorCode("The dates are not corect.");

            int minPrice = Configuration.GetConfigValue(configurations, Configuration.InitialScore);
            RuleFor(x => x).Must(args => this.CompareStartPrice(minPrice, args.Price)).WithErrorCode("The price is too low.");

            int maxOpenAuction = Configuration.GetConfigValue(configurations, Configuration.MaxRangeAuctionPerson);
            RuleFor(x => x).Must(args => this.CompareNumberOfAuction(maxOpenAuction, allOpenedAuction.Count)).WithErrorCode("The price is too low.");

            ///int maxOpenAuctionCat = Configuration.GetConfigValue(configurations, Configuration.MaxRangeAuctionCategoryPerson);
            ///RuleFor(x => x).Must(args => this.CompareNrAuctionSameCat(maxOpenAuctionCat,args.Product.CategoryName, allOpenedAuction)).WithErrorCode("The price is too low.");
        }

       
        //private bool CompareNrAuctionSameCat(int maxOpenAuction, int actualCat, IList<Auction> allOpenedAuction)
        //{
        //    int openedNrAucion = 0;
        //    foreach (var auction in allOpenedAuction)
        //        if (actualCat == auction.Product.CategoryName)
        //            openedNrAucion++;

        //    return openedNrAucion < maxOpenAuction;
        //}

        /// <summary>
        /// The CompareNumberOfAuction.
        /// </summary>
        /// <param name="maxOpenAuction">The maxOpenAuction<see cref="int"/>.</param>
        /// <param name="nrOpened">The nrOpened<see cref="int"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        private bool CompareNumberOfAuction(int maxOpenAuction, int nrOpened)
        {
            return nrOpened < maxOpenAuction;
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
