// <copyright file="ConfigValidator.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.DomainModel.Validator
{
    using FluentValidation;

    /// <summary>
    /// Defines the <see cref="ConfigValidator" />.
    /// </summary>
    public class ConfigValidator : AbstractValidator<Config>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigValidator"/> class.
        /// </summary>
        public ConfigValidator()
        {
            RuleFor(x => x.IdConfig).NotEmpty().WithErrorCode("This field is required.");
            RuleFor(x => x.IdConfig).Length(2, 20);
            RuleFor(x => x.ValueConfig).NotEmpty().WithErrorCode("This field is required.");
        }
    }
}
