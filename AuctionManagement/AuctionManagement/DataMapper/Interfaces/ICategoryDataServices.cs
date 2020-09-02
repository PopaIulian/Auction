// <copyright file="ICategoryDataServices.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.DataMapper
{
    using System.Collections.Generic;
    using AuctionManagement.DomainModel;

    /// <summary>
    /// Defines the <see cref="ICategoryDataServices" />.
    /// </summary>
    public interface ICategoryDataServices
    {
        /// <summary>
        /// The AddCategory.
        /// </summary>
        /// <param name="category">The category<see cref="Category"/>.</param>
        void AddCategory(Category category);

        /// <summary>
        /// The GetCategoryById.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="Category"/>.</returns>
        Category GetCategoryById(int id);

        /// <summary>
        /// The GetAllCategories.
        /// </summary>
        /// <returns>The <see cref="IList{Category}"/>.</returns>
        IList<Category> GetAllCategories();

        /// <summary>
        /// The UpdateCategory.
        /// </summary>
        /// <param name="category">The category<see cref="Category"/>.</param>
        void UpdateCategory(Category category);

        /// <summary>
        /// The DeleteCategory.
        /// </summary>
        /// <param name="category">The category<see cref="Category"/>.</param>
        void DeleteCategory(Category category);
    }
}
