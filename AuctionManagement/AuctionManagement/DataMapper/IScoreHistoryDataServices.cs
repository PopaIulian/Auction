using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionManagement.DataMapper
{ 
    using AuctionManagement.DomainModel;
    using System.Collections.Generic;

    public interface IScoreHistoryDataServices
    {
        void AddScoreHistory(ScoreHistory scoreHistory);

        ScoreHistory GetScoreHistoryById(int id);

        IList<ScoreHistory> GettAllScoreHistories();

        void UpdateScoreHistory(ScoreHistory scoreHistory);

        void DeleteScoreHistory(ScoreHistory scoreHistory);
    }
}
