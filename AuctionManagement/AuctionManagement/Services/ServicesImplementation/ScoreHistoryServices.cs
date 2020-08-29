using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuctionManagement.DataMapper;
using AuctionManagement.DomainModel;

namespace AuctionManagement.Services.ServicesImplementation
{
    class ScoreHistoryServices : IScoreHistoryServices
    {
        public static IScoreHistoryDataServices DataServices { get; set; }// = DaoFactoryMethod.CurrentDAOFactory.ScoreHistoryDataServices;

        public bool AddScoreHistory(ScoreHistory scoreHistory)
        {
            throw new NotImplementedException();
        }

        public bool DeleteScoreHistory(ScoreHistory scoreHistory)
        {
            throw new NotImplementedException();
        }

        public IList<ScoreHistory> GetListOfScoreHistories()
        {
            throw new NotImplementedException();
        }

        public ScoreHistory GetScoreHistoryById(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateScoreHistory(ScoreHistory scoreHistory)
        {
            throw new NotImplementedException();
        }
    }
}
