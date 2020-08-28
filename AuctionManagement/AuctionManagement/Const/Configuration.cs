using AuctionManagement.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionManagement.Const
{
    class Configuration
    {
        public const string AVERAGE_NUMBER_SCORE = "avg_number_score";

        public const string INITIAL_SCORE = "initial_score";

        public const string LOW_PRODUCT_PRICE = "low_price";

        public const string MAX_RANGE_AUCTION_PERSON = "max_auction";

        public const string MAX_RANGE_AUCTION_CATEGORY_PERSON = "max_auction_category";

        public const string MIN_SCORE_AUCTION = "min_score";

        public const string NUMBER_PAUSE_AUCTION_DAYS = "non_auction_days";

        public static int GetConfigValue(IList<Config> configuration, string textValue)
        {
            foreach (var config in configuration)
            {
                if (config.IdConfig == textValue)
                    return config.ValueConfig;
            }
            return 0;
        }

    }
}
