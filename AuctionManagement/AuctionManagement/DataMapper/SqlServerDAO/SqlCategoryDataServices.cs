// <copyright file="SqlCategoryDataServices.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.DataMapper.SqlServerDAO
{
    using System.Collections.Generic;
    using System.Linq;
    using AuctionManagement.DomainModel;

    /// <summary>
    /// Defines the <see cref="SqlCategoryDataServices" />.
    /// </summary>
    internal class SqlCategoryDataServices : ICategoryDataServices
    {
        /// <summary>
        /// The AddCategory.
        /// </summary>
        /// <param name="category">The category<see cref="Category"/>.</param>
        public void AddCategory(Category category)
        {
            using (Model1 context = new Model1())
            {
                context.Categories.Add(category);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// The DeleteCategory.
        /// </summary>
        /// <param name="category">The category<see cref="Category"/>.</param>
        public void DeleteCategory(Category category)
        {
            using (Model1 context = new Model1())
            {
                Category toBeDeleted = new Category { IdCategory = category.IdCategory };
                context.Categories.Attach(toBeDeleted);
                context.Categories.Remove(toBeDeleted);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// The GetCategoryById.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="Category"/>.</returns>
        public Category GetCategoryById(int id)
        {
            using (Model1 context = new Model1())
            {
                return context.Categories.Where(category => category.IdCategory == id).SingleOrDefault();
            }
        }

        /// <summary>
        /// The GetAllCategories.
        /// </summary>
        /// <returns>The <see cref="IList{Category}"/>.</returns>
        public IList<Category> GetAllCategories()
        {
            using (Model1 context = new Model1())
            {
                return context.Categories.Select(category => category).ToList();
            }
        }

        /// <summary>
        /// The UpdateCategory.
        /// </summary>
        /// <param name="category">The category<see cref="Category"/>.</param>
        public void UpdateCategory(Category category)
        {
            using (Model1 context = new Model1())
            {
                Category toBeUpdated = context.Categories.Find(category.IdCategory);

                if (toBeUpdated != null)
                {
                    context.Entry(toBeUpdated).CurrentValues.SetValues(category);
                    context.SaveChanges();
                }
            }
        }
    }
}
