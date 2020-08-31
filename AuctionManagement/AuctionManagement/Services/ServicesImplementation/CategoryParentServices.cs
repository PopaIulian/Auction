// <copyright file="CategoryParentServices.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.Services.ServicesImplementation
{
    using System.Collections.Generic;
    using AuctionManagement.DataMapper;
    using AuctionManagement.DomainModel;
    using AuctionManagement.DomainModel.Validator;
    using FluentValidation.Results;

    /// <summary>
    /// Defines the <see cref="CategoryParentServices" />.
    /// </summary>
    internal class CategoryParentServices : ICategoryParentServices
    {
        /// <summary>
        /// Defines the Log.
        /// </summary>
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(CategoryParentServices));

        /// <summary>
        /// Gets or sets the DataServices.
        /// </summary>
        public static ICategoryParentDataServices DataServices { get; set; } = DaoFactoryMethod.CurrentDAOFactory.CategoryParentDataServices;

        /// <summary>
        /// The AddCategoryParent.
        /// </summary>
        /// <param name="categoryParent">The categoryParent<see cref="CategoryParent"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool AddCategoryParent(CategoryParent categoryParent)
        {
            var validator = new CategoryParentValidator();
            ValidationResult results = validator.Validate(categoryParent);

            bool isValid = results.IsValid;

            if (isValid)
            {
                Log.Info("The category parent is valid!");
                DataServices.AddCategoryParent(categoryParent);
                Log.Info("The category parent was added to the database!");
            }
            else
            {
                IList<ValidationFailure> failures = results.Errors;
                Log.Error($"The category is not valid. The following errors occurred: {failures}");
            }

            return isValid;
        }

        /// <summary>
        /// The DeleteCategoryParent.
        /// </summary>
        /// <param name="categoryParent">The categoryParent<see cref="CategoryParent"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool DeleteCategoryParent(CategoryParent categoryParent)
        {
            var validator = new CategoryParentValidator();
            ValidationResult results = validator.Validate(categoryParent);

            bool isValid = results.IsValid;

            if (isValid)
            {
                Log.Info("The category parent is valid!");
                DataServices.DeleteCategoryParent(categoryParent);
                Log.Info("The category parent was added to the database!");
            }
            else
            {
                IList<ValidationFailure> failures = results.Errors;
                Log.Error($"The category is not valid. The following errors occurred: {failures}");
            }

            return isValid;
        }

        /// <summary>
        /// The GetCategoryParentById.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="CategoryParent"/>.</returns>
        public CategoryParent GetCategoryParentById(int id)
        {
            return DataServices.GetCategoryParentById(id);
        }

        /// <summary>
        /// The GetListOfCategories.
        /// </summary>
        /// <returns>The <see cref="IList{CategoryParent}"/>.</returns>
        public IList<CategoryParent> GetListOfCategories()
        {
            return DataServices.GetAllCategoriesParent();
        }

        /// <summary>
        /// The UpdateCategoryParent.
        /// </summary>
        /// <param name="categoryParent">The categoryParent<see cref="CategoryParent"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool UpdateCategoryParent(CategoryParent categoryParent)
        {
            var validator = new CategoryParentValidator();
            ValidationResult results = validator.Validate(categoryParent);

            bool isValid = results.IsValid;

            if (isValid)
            {
                Log.Info("The category parent is valid!");
                DataServices.UpdateCategoryParent(categoryParent);
                Log.Info("The category parent was added to the database!");
            }
            else
            {
                IList<ValidationFailure> failures = results.Errors;
                Log.Error($"The category is not valid. The following errors occurred: {failures}");
            }

            return isValid;
        }
    }
}
