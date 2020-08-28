using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionManagement.Services
{
    using AuctionManagement.DomainModel;
    using System.Collections.Generic;

    public interface IScoreHistoryServices
    {
        bool AddScoreHistory(ScoreHistory scoreHistory);

        ScoreHistory GetScoreHistoryById(int id);

        IList<ScoreHistory> GetListOfScoreHistories();

        bool UpdateScoreHistory(ScoreHistory scoreHistory);

        bool DeleteScoreHistory(ScoreHistory scoreHistory);
    }
}
