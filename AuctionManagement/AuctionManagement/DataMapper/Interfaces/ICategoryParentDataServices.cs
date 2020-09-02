// <copyright file="ICategoryParentDataServices.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.DataMapper
{
    using System.Collections.Generic;
    using AuctionManagement.DomainModel;

    /// <summary>
    /// Defines the <see cref="ICategoryParentDataServices" />.
    /// </summary>
    public interface ICategoryParentDataServices
    {
        /// <summary>
        /// The AddCategoryParent.
        /// </summary>
        /// <param name="categoryParent">The categoryParent<see cref="CategoryParent"/>.</param>
        void AddCategoryParent(CategoryParent categoryParent);

        /// <summary>
        /// The GetCategoryParentById.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="CategoryParent"/>.</returns>
        CategoryParent GetCategoryParentById(int id);

        /// <summary>
        /// The GetAllCategoriesParent.
        /// </summary>
        /// <returns>The <see cref="IList{CategoryParent}"/>.</returns>
        IList<CategoryParent> GetAllCategoriesParent();

        /// <summary>
        /// The UpdateCategoryParent.
        /// </summary>
        /// <param name="categoryParent">The categoryParent<see cref="CategoryParent"/>.</param>
        void UpdateCategoryParent(CategoryParent categoryParent);

        /// <summary>
        /// The DeleteCategoryParent.
        /// </summary>
        /// <param name="categoryParent">The categoryParent<see cref="CategoryParent"/>.</param>
        void DeleteCategoryParent(CategoryParent categoryParent);
    }
}
