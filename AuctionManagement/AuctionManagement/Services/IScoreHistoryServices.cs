// <copyright file="IScoreHistoryServices.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.Services
{
    using AuctionManagement.DomainModel;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="IScoreHistoryServices" />.
    /// </summary>
    public interface IScoreHistoryServices
    {
        /// <summary>
        /// The AddScoreHistory.
        /// </summary>
        /// <param name="scoreHistory">The scoreHistory<see cref="ScoreHistory"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        bool AddScoreHistory(ScoreHistory scoreHistory);

        /// <summary>
        /// The GetScoreHistoryById.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="ScoreHistory"/>.</returns>
        ScoreHistory GetScoreHistoryById(int id);

        /// <summary>
        /// The GetListOfScoreHistories.
        /// </summary>
        /// <returns>The <see cref="IList{ScoreHistory}"/>.</returns>
        IList<ScoreHistory> GetListOfScoreHistories();

        /// <summary>
        /// The UpdateScoreHistory.
        /// </summary>
        /// <param name="scoreHistory">The scoreHistory<see cref="ScoreHistory"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        bool UpdateScoreHistory(ScoreHistory scoreHistory);

        /// <summary>
        /// The DeleteScoreHistory.
        /// </summary>
        /// <param name="scoreHistory">The scoreHistory<see cref="ScoreHistory"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        bool DeleteScoreHistory(ScoreHistory scoreHistory);
    }
}
