// <copyright file="Configuration.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.Const
{
    using System.Collections.Generic;
    using AuctionManagement.DomainModel;

    /// <summary>
    /// Defines the <see cref="Configuration" />.
    /// </summary>
    internal class Configuration
    {
        /// <summary>
        /// Defines the AVERAGE_NUMBER_SCORE.
        /// </summary>
        public const string AverageNumberScore = "avg_number_score";

        /// <summary>
        /// Defines the INITIAL_SCORE.
        /// </summary>
        public const string InitialScore = "initial_score";

        /// <summary>
        /// Defines the LOW_PRODUCT_PRICE.
        /// </summary>
        public const string LowProductPrice = "low_price";

        /// <summary>
        /// Defines the MAX_RANGE_AUCTION_PERSON.
        /// </summary>
        public const string MaxRangeAuctionPerson = "max_auction";

        /// <summary>
        /// Defines the MAX_RANGE_AUCTION_CATEGORY_PERSON.
        /// </summary>
        public const string MaxRangeAuctionCategoryPerson = "max_auction_category";

        /// <summary>
        /// Defines the MIN_SCORE_AUCTION.
        /// </summary>
        public const string MinScoreAuction = "min_score";

        /// <summary>
        /// Defines the NUMBER_PAUSE_AUCTION_DAYS.
        /// </summary>
        public const string NumberPauseAuctionDays = "non_auction_days";

        /// <summary>
        /// Defines the OFFER_OBJECT_ROLE.
        /// </summary>
        public const string OfferObjectRole = "bidder";

        /// <summary>
        /// Defines the AUCTION_ROLE.
        /// </summary>
        public const string AuctionRole = "applicant";

        /// <summary>
        /// The GetConfigValue.
        /// </summary>
        /// <param name="configuration">The configuration<see cref="IList{Config}"/>.</param>
        /// <param name="textValue">The textValue<see cref="string"/>.</param>
        /// <returns>The <see cref="int"/>.</returns>
        public static int GetConfigValue(IList<Config> configuration, string textValue)
        {
            foreach (var config in configuration)
                if (config.IdConfig == textValue)
                {
                    return config.ValueConfig;
                }
            return 0;
        }
    }
}
