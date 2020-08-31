// <copyright file="CategoryServices.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.Services.ServicesImplementation
{
    using AuctionManagement.DataMapper;
    using AuctionManagement.DomainModel;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="CategoryServices" />.
    /// </summary>
    internal class CategoryServices : ICategoryServices
    {
        /// <summary>
        /// Defines the Log.
        /// </summary>
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(CategoryServices));

        /// <summary>
        /// Gets or sets the DataServices.
        /// </summary>
        public static ICategoryDataServices DataServices { get; set; } = DaoFactoryMethod.CurrentDAOFactory.CategoryDataServices;

        /// <summary>
        /// The AddCategory.
        /// </summary>
        /// <param name="category">The category<see cref="Category"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool AddCategory(Category category)
        {
            DataServices.AddCategory(category);
            return true;
        }

        /// <summary>
        /// The DeleteCategory.
        /// </summary>
        /// <param name="category">The category<see cref="Category"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool DeleteCategory(Category category)
        {
            DataServices.DeleteCategory(category);
            return true;
        }

        /// <summary>
        /// The GetCategoryById.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="Category"/>.</returns>
        public Category GetCategoryById(int id)
        {
            return DataServices.GetCategoryById(id);
        }

        /// <summary>
        /// The GetListOfCategories.
        /// </summary>
        /// <returns>The <see cref="IList{Category}"/>.</returns>
        public IList<Category> GetListOfCategories()
        {
            return DataServices.GetAllCategories();
        }

        /// <summary>
        /// The UpdateCategory.
        /// </summary>
        /// <param name="category">The category<see cref="Category"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool UpdateCategory(Category category)
        {
            DataServices.UpdateCategory(category);
            return true;
        }
    }
}
