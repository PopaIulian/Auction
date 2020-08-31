// <copyright file="ScoreHistoryValidator.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.DomainModel.Validator
{
    using FluentValidation;

    /// <summary>
    /// Defines the <see cref="ScoreHistoryValidator" />.
    /// </summary>
    public class ScoreHistoryValidator : AbstractValidator<ScoreHistory>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreHistoryValidator"/> class.
        /// </summary>
        public ScoreHistoryValidator()
        {
            RuleFor(x => x.IdScoreHistory).NotEmpty().WithErrorCode("This field is required.");
            RuleFor(x => x.DateScore).NotEmpty().WithErrorCode("This field is required.");
            RuleFor(x => x.PersonId).NotEmpty().WithErrorCode("This field is required.");
            RuleFor(x => x.Score).NotEmpty().WithErrorCode("This field is required.");
        }
    }
}
