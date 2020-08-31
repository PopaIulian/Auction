// <copyright file="ScoreHistoryServices.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.Services.ServicesImplementation
{
    using System.Collections.Generic;
    using AuctionManagement.DataMapper;
    using AuctionManagement.DomainModel;
    using AuctionManagement.DomainModel.Validator;
    using FluentValidation.Results;

    /// <summary>
    /// Defines the <see cref="ScoreHistoryServices" />.
    /// </summary>
    internal class ScoreHistoryServices : IScoreHistoryServices
    {
        /// <summary>
        /// Defines the Log.
        /// </summary>
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(AuctionServices));

        /// <summary>
        /// Gets or sets the DataServices.
        /// </summary>
        public static IScoreHistoryDataServices DataServices { get; set; } = DaoFactoryMethod.CurrentDAOFactory.ScoreHistoryServices;

        /// <summary>
        /// The AddScoreHistory.
        /// </summary>
        /// <param name="scoreHistory">The scoreHistory<see cref="ScoreHistory"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool AddScoreHistory(ScoreHistory scoreHistory)
        {
            var validator = new ScoreHistoryValidator();
            ValidationResult results = validator.Validate(scoreHistory);

            bool isValid = results.IsValid;

            if (isValid)
            {
                Log.Info("The score history is valid!");
                DataServices.AddScoreHistory(scoreHistory);
                Log.Info("The score history was added to the database!");
            }
            else
            {
                IList<ValidationFailure> failures = results.Errors;
                Log.Error($"The score history is not valid. The following errors occurred: {failures}");
            }

            return isValid;
        }

        /// <summary>
        /// The DeleteScoreHistory.
        /// </summary>
        /// <param name="scoreHistory">The scoreHistory<see cref="ScoreHistory"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool DeleteScoreHistory(ScoreHistory scoreHistory)
        {
            var validator = new ScoreHistoryValidator();
            ValidationResult results = validator.Validate(scoreHistory);

            bool isValid = results.IsValid;

            if (isValid)
            {
                Log.Info("The score history is valid!");
                DataServices.DeleteScoreHistory(scoreHistory);
                Log.Info("The score history was deleted to the database!");
            }
            else
            {
                IList<ValidationFailure> failures = results.Errors;
                Log.Error($"The score history is not valid. The following errors occurred: {failures}");
            }

            return isValid;
        }

        /// <summary>
        /// The GetListOfScoreHistories.
        /// </summary>
        /// <returns>The <see cref="IList{ScoreHistory}"/>.</returns>
        public IList<ScoreHistory> GetListOfScoreHistories()
        {
            return DataServices.GetAllScoreHistories();
        }

        /// <summary>
        /// The GetScoreHistoryById.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="ScoreHistory"/>.</returns>
        public ScoreHistory GetScoreHistoryById(int id)
        {
            return DataServices.GetScoreHistoryById(id);
        }

        /// <summary>
        /// The UpdateScoreHistory.
        /// </summary>
        /// <param name="scoreHistory">The scoreHistory<see cref="ScoreHistory"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool UpdateScoreHistory(ScoreHistory scoreHistory)
        {
            var validator = new ScoreHistoryValidator();
            ValidationResult results = validator.Validate(scoreHistory);

            bool isValid = results.IsValid;

            if (isValid)
            {
                Log.Info("The history score is valid!");
                DataServices.UpdateScoreHistory(scoreHistory);
                Log.Info("The history score was updated to the database!");
            }
            else
            {
                IList<ValidationFailure> failures = results.Errors;
                Log.Error($"The score history is not valid. The following errors occurred: {failures}");
            }

            return isValid;
        }
    }
}
