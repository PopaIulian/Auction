

namespace AuctionManagement.DataMapper.SqlServerDAO
{
    using System.Collections.Generic;
    using System.Linq;
    using AuctionManagement.DomainModel;

    class SqlScoreHistoryServices : IScoreHistoryDataServices
    {
        public void AddScoreHistory(ScoreHistory scoreHistory)
        {
            using (Context context = new Context())
            {
                context.ScoreHistories.Add(scoreHistory);
                context.SaveChanges();
            }
        }

        public void DeleteScoreHistory(ScoreHistory scoreHistory)
        {
            using (Context context = new Context())
            {
                ScoreHistory toBeDeleted = new ScoreHistory { IdScoreHistory = scoreHistory.IdScoreHistory };
                context.ScoreHistories.Attach(toBeDeleted);
                context.ScoreHistories.Remove(toBeDeleted);
                context.SaveChanges();
            }
        }

        public ScoreHistory GetScoreHistoryById(int id)
        {
            using (Context context = new Context())
            {
                return context.ScoreHistories.Where(scoreHistory => scoreHistory.IdScoreHistory == id).SingleOrDefault();
            }
        }

        public IList<ScoreHistory> GettAllScoreHistories()
        {
            using (Context context = new Context())
            {
                return context.ScoreHistories.Select(scoreHistory => scoreHistory).ToList();
            }
        }

        public void UpdateScoreHistory(ScoreHistory scoreHistory)
        {
            using (Context context = new Context())
            {
                ScoreHistory toBeUpdated = context.ScoreHistories.Find(scoreHistory.IdScoreHistory);

                if (toBeUpdated == null)
                {
                    return;
                }
                context.Entry(toBeUpdated).CurrentValues.SetValues(scoreHistory);
                context.SaveChanges();
            }
        }
    }
}

 