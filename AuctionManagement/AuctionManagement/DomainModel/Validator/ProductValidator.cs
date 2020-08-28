using System;


namespace AuctionManagement.DomainModel.Validator
{
    using FluentValidation;

    public class ProductValidator : AbstractValidator<Product>
    {
        /// <summary>Initializes a new instance of the <see cref="PublishingHouseValidator"/> class.</summary>
        public ProductValidator()
        {
            RuleFor(x => x.IdProduct).NotEmpty().WithErrorCode("This field is required.");
            RuleFor(x => x.ObjectName).NotEmpty().WithErrorCode("This field is required.");
            RuleFor(x => x.ObjectName).Length(2, 20);
        }
    }
}
