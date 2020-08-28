// <copyright file="ICategoryServices.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.Services
{
    using AuctionManagement.DomainModel;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="ICategoryServices" />.
    /// </summary>
    public interface ICategoryServices
    {
        /// <summary>
        /// The AddCategory.
        /// </summary>
        /// <param name="category">The category<see cref="Category"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        bool AddCategory(Category category);

        /// <summary>
        /// The GetCategoryById.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="Category"/>.</returns>
        Category GetCategoryById(int id);

        /// <summary>
        /// The GetListOfCategories.
        /// </summary>
        /// <returns>The <see cref="IList{Category}"/>.</returns>
        IList<Category> GetListOfCategories();

        /// <summary>
        /// The UpdateCategory.
        /// </summary>
        /// <param name="category">The category<see cref="Category"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        bool UpdateCategory(Category category);

        /// <summary>
        /// The DeleteCategory.
        /// </summary>
        /// <param name="category">The category<see cref="Category"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        bool DeleteCategory(Category category);
    }
}
