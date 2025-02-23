﻿// <copyright file="PersonValidator.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.DomainModel.Validator
{
    using AuctionManagement.Const;
    using FluentValidation;

    /// <summary>
    /// Defines the <see cref="PersonValidator" />.
    /// </summary>
    public class PersonValidator : AbstractValidator<Person>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonValidator"/> class.
        /// </summary>
        public PersonValidator()
        {
            RuleFor(x => x.IdPerson).NotEmpty().WithErrorCode("This field is required.");
            RuleFor(x => x.Username).NotEmpty().WithErrorCode("This field is required.");
            RuleFor(x => x.Username).Length(2, 20);
            RuleFor(x => x.PersonRole).NotEmpty().WithErrorCode("This field is required.");
            RuleFor(x => x.PersonRole).Length(2, 20);
            RuleFor(x => x).Must(args => this.CompareRole(args.PersonRole)).WithErrorCode("The role is wrong.");
        }

        /// <summary>
        /// The CompareRole.
        /// </summary>
        /// <param name="role">The role<see cref="string"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        private bool CompareRole(string role)
        {
            return role == Configuration.AuctionRole || role == Configuration.OfferObjectRole;
        }
    }
}
