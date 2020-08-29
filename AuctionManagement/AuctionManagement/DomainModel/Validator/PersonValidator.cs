

namespace AuctionManagement.DomainModel.Validator
{
    using AuctionManagement.Const;
    using FluentValidation;

    public class PersonValidator : AbstractValidator<Person>
    {
        /// <summary>Initializes a new instance of the <see cref="PublishingHouseValidator"/> class.</summary>
        public PersonValidator()
        {
            RuleFor(x => x.IdPerson).NotEmpty().WithErrorCode("This field is required.");
            RuleFor(x => x.Username).NotEmpty().WithErrorCode("This field is required.");
            RuleFor(x => x.Username).Length(2, 20);
            RuleFor(x => x.PersonRole).NotEmpty().WithErrorCode("This field is required.");
            RuleFor(x => x.PersonRole).Length(2, 20);
            RuleFor(x => x).Must(args => this.CompareRole(args.PersonRole)).WithErrorCode("The role is wrong.");
        }




        private bool CompareRole(string role)
        {
            return (role == Configuration.AUCTION_ROLE || role == Configuration.OFFER_OBJECT_ROLE);
        }
    }
}
