// <copyright file="ProductValidator.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.DomainModel.Validator
{
    using FluentValidation;

    /// <summary>
    /// Defines the <see cref="ProductValidator" />.
    /// </summary>
    public class ProductValidator : AbstractValidator<Product>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductValidator"/> class.
        /// </summary>
        public ProductValidator()
        {
            RuleFor(x => x.IdProduct).NotEmpty().WithErrorCode("This field is required.");
            RuleFor(x => x.ObjectName).NotEmpty().WithErrorCode("This field is required.");
            RuleFor(x => x.ObjectName).Length(2, 20);
        }
    }
}
