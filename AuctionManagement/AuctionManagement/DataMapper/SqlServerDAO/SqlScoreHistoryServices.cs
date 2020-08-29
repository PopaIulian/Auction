// <copyright file="SqlScoreHistoryServices.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.DataMapper.SqlServerDAO
{
    using System.Collections.Generic;
    using System.Linq;
    using AuctionManagement.DomainModel;

    /// <summary>
    /// Defines the <see cref="SqlScoreHistoryServices" />.
    /// </summary>
    internal class SqlScoreHistoryServices : IScoreHistoryDataServices
    {
        /// <summary>
        /// The AddScoreHistory.
        /// </summary>
        /// <param name="scoreHistory">The scoreHistory<see cref="ScoreHistory"/>.</param>
        public void AddScoreHistory(ScoreHistory scoreHistory)
        {
            using (Model1 context = new Model1())
            {
                context.ScoreHistories.Add(scoreHistory);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// The DeleteScoreHistory.
        /// </summary>
        /// <param name="scoreHistory">The scoreHistory<see cref="ScoreHistory"/>.</param>
        public void DeleteScoreHistory(ScoreHistory scoreHistory)
        {
            using (Model1 context = new Model1())
            {
                ScoreHistory toBeDeleted = new ScoreHistory { IdScoreHistory = scoreHistory.IdScoreHistory };
                context.ScoreHistories.Attach(toBeDeleted);
                context.ScoreHistories.Remove(toBeDeleted);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// The GetScoreHistoryById.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="ScoreHistory"/>.</returns>
        public ScoreHistory GetScoreHistoryById(int id)
        {
            using (Model1 context = new Model1())
            {
                return context.ScoreHistories.Where(scoreHistory => scoreHistory.IdScoreHistory == id).SingleOrDefault();
            }
        }

        /// <summary>
        /// The GetAllScoreHistories.
        /// </summary>
        /// <returns>The <see cref="IList{ScoreHistory}"/>.</returns>
        public IList<ScoreHistory> GetAllScoreHistories()
        {
            using (Model1 context = new Model1())
            {
                return context.ScoreHistories.Select(scoreHistory => scoreHistory).ToList();
            }
        }

        /// <summary>
        /// The UpdateScoreHistory.
        /// </summary>
        /// <param name="scoreHistory">The scoreHistory<see cref="ScoreHistory"/>.</param>
        public void UpdateScoreHistory(ScoreHistory scoreHistory)
        {
            using (Model1 context = new Model1())
            {
                ScoreHistory toBeUpdated = context.ScoreHistories.Find(scoreHistory.IdScoreHistory);

                if (toBeUpdated != null)
                {
                    context.Entry(toBeUpdated).CurrentValues.SetValues(scoreHistory);
                    context.SaveChanges();
                }
            }
        }
    }
}
