// <copyright file="ICategoryParentServices.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.Services
{
    using System.Collections.Generic;
    using AuctionManagement.DomainModel;

    /// <summary>
    /// Defines the <see cref="ICategoryParentServices" />.
    /// </summary>
    public interface ICategoryParentServices
    {
        /// <summary>
        /// The AddCategoryParent.
        /// </summary>
        /// <param name="categoryParent">The categoryParent<see cref="CategoryParent"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        bool AddCategoryParent(CategoryParent categoryParent);

        /// <summary>
        /// The GetCategoryParentById.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="CategoryParent"/>.</returns>
        CategoryParent GetCategoryParentById(int id);

        /// <summary>
        /// The GetListOfCategories.
        /// </summary>
        /// <returns>The <see cref="IList{CategoryParent}"/>.</returns>
        IList<CategoryParent> GetListOfCategories();

        /// <summary>
        /// The UpdateCategoryParent.
        /// </summary>
        /// <param name="categoryParent">The categoryParent<see cref="CategoryParent"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        bool UpdateCategoryParent(CategoryParent categoryParent);

        /// <summary>
        /// The DeleteCategoryParent.
        /// </summary>
        /// <param name="categoryParent">The categoryParent<see cref="CategoryParent"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        bool DeleteCategoryParent(CategoryParent categoryParent);
    }
}
