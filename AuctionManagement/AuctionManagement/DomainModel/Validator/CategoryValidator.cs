// <copyright file="CategoryValidator.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.DomainModel.Validator
{
    using FluentValidation;

    /// <summary>
    /// Defines the <see cref="CategoryValidator" />.
    /// </summary>
    public class CategoryValidator : AbstractValidator<Category>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryValidator"/> class.
        /// </summary>
        public CategoryValidator()
        {
            RuleFor(x => x.IdCategory).NotEmpty().WithErrorCode("This field is required.");
            RuleFor(x => x.CategoryName).NotEmpty().WithErrorCode("This field is required.");
            RuleFor(x => x.CategoryName).Length(2, 20);
        }
    }
}
