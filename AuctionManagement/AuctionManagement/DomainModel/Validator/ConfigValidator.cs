using System;


namespace AuctionManagement.DomainModel.Validator
{
    using FluentValidation;

    public class ConfigValidator : AbstractValidator<Config>
    {
        /// <summary>Initializes a new instance of the <see cref="PublishingHouseValidator"/> class.</summary>
        public ConfigValidator()
        {
            RuleFor(x => x.IdConfig).NotEmpty().WithErrorCode("This field is required.");
            RuleFor(x => x.IdConfig).Length(2, 20);
            RuleFor(x => x.ValueConfig).NotEmpty().WithErrorCode("This field is required.");
        }
    }
}
