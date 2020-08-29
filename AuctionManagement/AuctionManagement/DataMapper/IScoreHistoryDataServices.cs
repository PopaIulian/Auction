// <copyright file="IScoreHistoryDataServices.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.DataMapper
{
    using System.Collections.Generic;
    using AuctionManagement.DomainModel;

    /// <summary>
    /// Defines the <see cref="IScoreHistoryDataServices" />.
    /// </summary>
    public interface IScoreHistoryDataServices
    {
        /// <summary>
        /// The AddScoreHistory.
        /// </summary>
        /// <param name="scoreHistory">The scoreHistory<see cref="ScoreHistory"/>.</param>
        void AddScoreHistory(ScoreHistory scoreHistory);

        /// <summary>
        /// The GetScoreHistoryById.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="ScoreHistory"/>.</returns>
        ScoreHistory GetScoreHistoryById(int id);

        /// <summary>
        /// The GetAllScoreHistories.
        /// </summary>
        /// <returns>The <see cref="IList{ScoreHistory}"/>.</returns>
        IList<ScoreHistory> GetAllScoreHistories();

        /// <summary>
        /// The UpdateScoreHistory.
        /// </summary>
        /// <param name="scoreHistory">The scoreHistory<see cref="ScoreHistory"/>.</param>
        void UpdateScoreHistory(ScoreHistory scoreHistory);

        /// <summary>
        /// The DeleteScoreHistory.
        /// </summary>
        /// <param name="scoreHistory">The scoreHistory<see cref="ScoreHistory"/>.</param>
        void DeleteScoreHistory(ScoreHistory scoreHistory);
    }
}
