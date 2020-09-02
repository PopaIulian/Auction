// <copyright file="SqlScoreHistoryServices.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.DataMapper.SqlServerDAO
{
    using System.Collections.Generic;
    using AuctionManagement.DomainModel;
    using System.Linq;

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
            using (AppContext context = new AppContext())
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
            using (AppContext context = new AppContext())
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
            using (AppContext context = new AppContext())
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
            using (AppContext context = new AppContext())
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
            using (AppContext context = new AppContext())
            {
                ScoreHistory toBeUpdated = context.ScoreHistories.Find(scoreHistory.IdScoreHistory);

                if (toBeUpdated != null)
                {
                    context.Entry(toBeUpdated).CurrentValues.SetValues(scoreHistory);
                    context.SaveChanges();
                }
            }
        }

        /// <summary>
        /// The GetAllScores.
        /// </summary>
        /// <param name="userId">The userId<see cref="int"/>.</param>
        /// <returns>The <see cref="IList{ScoreHistory}"/>.</returns>
        public IList<ScoreHistory> GetAllScoresUser(int userId)
        {
            using (AppContext context = new AppContext())
            {
                return context.ScoreHistories.Where(score => score.PersonId == userId).ToList();
            }
        }
    }
}
