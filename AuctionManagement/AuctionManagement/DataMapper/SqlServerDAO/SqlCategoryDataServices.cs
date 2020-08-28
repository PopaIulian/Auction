
namespace AuctionManagement.DataMapper.SqlServerDAO
{
  using System.Collections.Generic;
    using System.Linq;
    using AuctionManagement.DomainModel;

    class SqlCategoryDataServices : ICategoryDataServices
    {
        public void AddCategory(Category category)
        {
            using (Context context = new Context())
            {
                context.Categories.Add(category);
                context.SaveChanges();
            }
        }

        public void DeleteCategory(Category category)
        {
            using (Context context = new Context())
            {
                Category toBeDeleted = new Category { IdCategory = category.IdCategory };
                context.Categories.Attach(toBeDeleted);
                context.Categories.Remove(toBeDeleted);
                context.SaveChanges();
            }
        }

        public Category GetCategoryById(int id)
        {
            using (Context context = new Context())
            {
                return context.Categories.Where(category => category.IdCategory == id).SingleOrDefault();
            }
        }

        public IList<Category> GettAllCategories()
        {
            using (Context context = new Context())
            {
                return context.Categories.Select(category => category).ToList();
            }
        }

        public void UpdateCategory(Category category)
        {
            using (Context context = new Context())
            {
                Category toBeUpdated = context.Categories.Find(category.IdCategory);

                if (toBeUpdated == null)
                {
                    return;
                }
                context.Entry(toBeUpdated).CurrentValues.SetValues(category);
                context.SaveChanges();
            }
        }
    }
}

 