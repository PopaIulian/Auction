// <copyright file="CategoryParentValidator.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.DomainModel.Validator
{
    using FluentValidation;

    /// <summary>
    /// Defines the <see cref="CategoryParentValidator" />.
    /// </summary>
    public class CategoryParentValidator : AbstractValidator<CategoryParent>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryParentValidator"/> class.
        /// </summary>
        public CategoryParentValidator()
        {
            RuleFor(x => x.IdCategoryParent).NotEmpty().WithErrorCode("This field is required.");
            RuleFor(x => x.CategoryId).NotEmpty().WithErrorCode("This field is required.");
            RuleFor(x => x.ParentId).NotEmpty().WithErrorCode("This field is required.");
        }
    }
}
