using System;


namespace AuctionManagement.DomainModel.Validator
{
   using FluentValidation;

    public class CategoryValidator : AbstractValidator<Category>
    {
        /// <summary>Initializes a new instance of the <see cref="PublishingHouseValidator"/> class.</summary>
        public CategoryValidator()
        {
            RuleFor(x => x.IdCategory).NotEmpty().WithErrorCode("This field is required.");
            RuleFor(x => x.CategoryName).NotEmpty().WithErrorCode("This field is required.");
            RuleFor(x => x.CategoryName).Length(2, 20);
        }
    }
}
