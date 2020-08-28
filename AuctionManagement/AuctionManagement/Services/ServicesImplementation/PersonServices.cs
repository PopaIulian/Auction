

namespace AuctionManagement.Services.ServicesImplementation
{
    using System;
    using System.Collections.Generic;
    using AuctionManagement.DataMapper;
    using AuctionManagement.DomainModel;
    //using FluentValidation.Results;

    public class PersonServices : IPersonServices
    {
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(PersonServices));

        public static IPersonDataServices DataServices { get; set; } = DaoFactoryMethod.CurrentDAOFactory.PersonDataServices;

        public bool AddPerson(Person person)
        {
            //var validator = new AuthorValidator();
            //ValidationResult results = validator.Validate(author);

            //bool isValid = results.IsValid;

            //if (isValid)
            //{
            //    Log.Info("The author is valid!");
            //    DataServices.AddAuthor(author);
            //    Log.Info("The author was added to the database!");
            //}
            //else
            //{
            //    IList<ValidationFailure> failures = results.Errors;
            //    Log.Error($"The author is not valid. The following errors occurred: {failures}");
            //}

            //return isValid;
            return true;
        }

        public bool DeletePerson(Person person)
        {
            throw new NotImplementedException();
        }

        public IList<Person> GetListOfPersons()
        {
            throw new NotImplementedException();
        }

        public Person GetPersonById(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdatePerson(Person person)
        {
            throw new NotImplementedException();
        }
    }
}


//namespace BookLibraryManagement.Services.ServicesImplementation
//{
 

//    /// <summary>AuthorServices implementation.</summary>
//    /// <seealso cref="BookLibraryManagement.Services.IAuthorServices" />
//    public class AuthorServices : IAuthorServices
//    {
//        /// <summary>The log.</summary>
       

//        /// <summary>Adds the author.</summary>
//        /// <param name="author">The author parameter.</param>
//        /// <returns>The author.</returns>
//        public bool AddAuthor(Author author)
//        {
//            var validator = new AuthorValidator();
//            ValidationResult results = validator.Validate(author);

//            bool isValid = results.IsValid;

//            if (isValid)
//            {
//                Log.Info("The author is valid!");
//                DataServices.AddAuthor(author);
//                Log.Info("The author was added to the database!");
//            }
//            else
//            {
//                IList<ValidationFailure> failures = results.Errors;
//                Log.Error($"The author is not valid. The following errors occurred: {failures}");
//            }

//            return isValid;
//        }

//        /// <summary>Deletes the author.</summary>
//        /// <param name="author">The author parameter.</param>
//        /// <returns>The author.</returns>
//        public bool DeleteAuthor(Author author)
//        {
//            var validator = new AuthorValidator();
//            ValidationResult results = validator.Validate(author);

//            bool isValid = results.IsValid;

//            if (isValid)
//            {
//                Log.Info("The author is valid!");
//                DataServices.DeleteAuthor(author);
//                Log.Info("The author was deleted from the database!");
//            }
//            else
//            {
//                IList<ValidationFailure> failures = results.Errors;
//                Log.Error($"The author is not valid. The following errors occurred: {failures}");
//            }

//            return isValid;
//        }

//        /// <summary>Gets the list of authors.</summary>
//        /// <returns>List of authors.</returns>
//        public IList<Author> GetListOfAuthors()
//        {
//            return DataServices.GettAllAuthors();
//        }

//        /// <summary>Gets the book by author.</summary>
//        /// <param name="id">The identifier.</param>
//        /// <returns>The author.</returns>
//        public Author GetAuthorById(int id)
//        {
//            return DataServices.GetAuthorById(id);
//        }

//        /// <summary>Updates the author.</summary>
//        /// <param name="author">The author.</param>
//        /// <returns>Successful operation or not.</returns>
//        public bool UpdateAuthor(Author author)
//        {
//            var validator = new AuthorValidator();
//            ValidationResult results = validator.Validate(author);

//            bool isValid = results.IsValid;

//            if (isValid)
//            {
//                Log.Info("The author is valid!");
//                DataServices.UpdateAuthor(author);
//                Log.Info("The author was updated in the database!");
//            }
//            else
//            {
//                IList<ValidationFailure> failures = results.Errors;
//                Log.Error($"The author is not valid. The following errors occurred: {failures}");
//            }

//            return isValid;
//        }
//    }
//}

