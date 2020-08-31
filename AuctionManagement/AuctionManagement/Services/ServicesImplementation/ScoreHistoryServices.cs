// <copyright file="ScoreHistoryServices.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.Services.ServicesImplementation
{
    using AuctionManagement.DataMapper;
    using AuctionManagement.DomainModel;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="ScoreHistoryServices" />.
    /// </summary>
    internal class ScoreHistoryServices : IScoreHistoryServices
    {
        /// <summary>
        /// Gets or sets the DataServices.
        /// </summary>
        public static IScoreHistoryDataServices DataServices { get; set; }

        /// <summary>
        /// The AddScoreHistory.
        /// </summary>
        /// <param name="scoreHistory">The scoreHistory<see cref="ScoreHistory"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool AddScoreHistory(ScoreHistory scoreHistory)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The DeleteScoreHistory.
        /// </summary>
        /// <param name="scoreHistory">The scoreHistory<see cref="ScoreHistory"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool DeleteScoreHistory(ScoreHistory scoreHistory)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The GetListOfScoreHistories.
        /// </summary>
        /// <returns>The <see cref="IList{ScoreHistory}"/>.</returns>
        public IList<ScoreHistory> GetListOfScoreHistories()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The GetScoreHistoryById.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="ScoreHistory"/>.</returns>
        public ScoreHistory GetScoreHistoryById(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The UpdateScoreHistory.
        /// </summary>
        /// <param name="scoreHistory">The scoreHistory<see cref="ScoreHistory"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool UpdateScoreHistory(ScoreHistory scoreHistory)
        {
            throw new NotImplementedException();
        }
    }
}
