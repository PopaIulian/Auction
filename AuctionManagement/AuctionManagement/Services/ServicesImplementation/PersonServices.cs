// <copyright file="PersonServices.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.Services.ServicesImplementation
{
    using AuctionManagement.DataMapper;
    using AuctionManagement.DomainModel;
    using AuctionManagement.DomainModel.Validator;
    using FluentValidation.Results;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="PersonServices" />.
    /// </summary>
    public class PersonServices : IPersonServices
    {
      
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(PersonServices));

      
        public static IPersonDataServices DataServices { get; set; } = DaoFactoryMethod.CurrentDAOFactory.PersonDataServices;

       
        public bool AddPerson(Person person)
        {
            var validator = new PersonValidator();
            ValidationResult results = validator.Validate(person);

            bool isValid = results.IsValid;

            if (isValid)
            {
                Log.Info("The auction is valid!");
                DataServices.AddPerson(person);
                Log.Info("The auction was added to the database!");
            }
            else
            {
                IList<ValidationFailure> failures = results.Errors;
                Log.Error($"The auction is not valid. The following errors occurred: {failures}");
            }

            return isValid;
        }

        /// <summary>
        /// The DeletePerson.
        /// </summary>
        /// <param name="person">The person<see cref="Person"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool DeletePerson(Person person)
        {
            var validator = new PersonValidator();
            ValidationResult results = validator.Validate(person);

            bool isValid = results.IsValid;

            if (isValid)
            {
                Log.Info("The auction is valid!");
                DataServices.DeletePerson(person);
                Log.Info("The auction was deleted to the database!");
            }
            else
            {
                IList<ValidationFailure> failures = results.Errors;
                Log.Error($"The auction is not valid. The following errors occurred: {failures}");
            }

            return isValid;
        }

        /// <summary>
        /// The GetListOfPersons.
        /// </summary>
        /// <returns>The <see cref="IList{Person}"/>.</returns>
        public IList<Person> GetListOfPersons()
        {
            return DataServices.GetAllPersons();
        }

        /// <summary>
        /// The GetPersonById.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="Person"/>.</returns>
        public Person GetPersonById(int id)
        {
            return DataServices.GetPersonById(id);
        }

        /// <summary>
        /// The UpdatePerson.
        /// </summary>
        /// <param name="person">The person<see cref="Person"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool UpdatePerson(Person person)
        {
            var validator = new PersonValidator();
            ValidationResult results = validator.Validate(person);

            bool isValid = results.IsValid;

            if (isValid)
            {
                Log.Info("The auction is valid!");
                DataServices.UpdatePerson(person);
                Log.Info("The auction was updated to the database!");
            }
            else
            {
                IList<ValidationFailure> failures = results.Errors;
                Log.Error($"The auction is not valid. The following errors occurred: {failures}");
            }

            return isValid;
        }
    }
}

