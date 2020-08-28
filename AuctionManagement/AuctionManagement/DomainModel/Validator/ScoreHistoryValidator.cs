

namespace AuctionManagement.DomainModel.Validator
{
    using FluentValidation;

    public class ScoreHistoryValidator : AbstractValidator<ScoreHistory>
    {
        /// <summary>Initializes a new instance of the <see cref="PublishingHouseValidator"/> class.</summary>
        public ScoreHistoryValidator()
        {
            RuleFor(x => x.IdScoreHistory).NotEmpty().WithErrorCode("This field is required.");
            RuleFor(x => x.DateScore).NotEmpty().WithErrorCode("This field is required.");
            RuleFor(x => x.PersonId).NotEmpty().WithErrorCode("This field is required.");
            RuleFor(x => x.Score).NotEmpty().WithErrorCode("This field is required.");

        }
    }
}
