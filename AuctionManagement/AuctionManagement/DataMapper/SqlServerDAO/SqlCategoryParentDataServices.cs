// <copyright file="SqlCategoryParentDataServices.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.DataMapper.SqlServerDAO
{
    using System.Collections.Generic;
    using System.Linq;
    using AuctionManagement.DomainModel;

    /// <summary>
    /// Defines the <see cref="SqlCategoryParentDataServices" />.
    /// </summary>
    internal class SqlCategoryParentDataServices : ICategoryParentDataServices
    {
        /// <summary>
        /// The AddCategoryParent.
        /// </summary>
        /// <param name="categoryParent">The categoryParent<see cref="CategoryParent"/>.</param>
        public void AddCategoryParent(CategoryParent categoryParent)
        {
            using (AppContext context = new AppContext())
            {
                context.CategoryParents.Add(categoryParent);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// The DeleteCategoryParent.
        /// </summary>
        /// <param name="categoryParent">The categoryParent<see cref="CategoryParent"/>.</param>
        public void DeleteCategoryParent(CategoryParent categoryParent)
        {
            using (AppContext context = new AppContext())
            {
                CategoryParent toBeDeleted = new CategoryParent { IdCategoryParent = categoryParent.IdCategoryParent };
                context.CategoryParents.Attach(toBeDeleted);
                context.CategoryParents.Remove(toBeDeleted);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// The GetCategoryParentById.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="CategoryParent"/>.</returns>
        public CategoryParent GetCategoryParentById(int id)
        {
            using (AppContext context = new AppContext())
            {
                return context.CategoryParents.Where(category => category.IdCategoryParent == id).SingleOrDefault();
            }
        }

        /// <summary>
        /// The GetAllCategoriesParent.
        /// </summary>
        /// <returns>The <see cref="IList{CategoryParent}"/>.</returns>
        public IList<CategoryParent> GetAllCategoriesParent()
        {
            using (AppContext context = new AppContext())
            {
                return context.CategoryParents.Select(categoryParent => categoryParent).ToList();
            }
        }

        /// <summary>
        /// The UpdateCategoryParent.
        /// </summary>
        /// <param name="categoryParent">The categoryParent<see cref="CategoryParent"/>.</param>
        public void UpdateCategoryParent(CategoryParent categoryParent)
        {
            using (AppContext context = new AppContext())
            {
                Category toBeUpdated = context.Categories.Find(categoryParent.IdCategoryParent);

                if (toBeUpdated != null)
                {
                    context.Entry(toBeUpdated).CurrentValues.SetValues(categoryParent);
                    context.SaveChanges();
                }
            }
        }
    }
}
