using AuctionManagement.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionManagement.DataMapper.SqlServerDAO
{
    class SqlCategoryParentDataServices : ICategoryParentDataServices
    {
       
        public void AddCategoryParent(CategoryParent categoryParent)
        {
            using (Model1 context = new Model1())
            {
                context.CategoryParents.Add(categoryParent);
                context.SaveChanges();
            }
        }
        
        public void DeleteCategoryParent(CategoryParent categoryParent)
        {
            using (Model1 context = new Model1())
            {
                CategoryParent toBeDeleted = new CategoryParent { IdCategoryParent = categoryParent.IdCategoryParent };
                context.CategoryParents.Attach(toBeDeleted);
                context.CategoryParents.Remove(toBeDeleted);
                context.SaveChanges();
            }
        }

      
        public CategoryParent GetCategoryParentById(int id)
        {
            using (Model1 context = new Model1())
            {
                return context.CategoryParents.Where(category => category.IdCategoryParent == id).SingleOrDefault();
            }
        }

      
        public IList<CategoryParent> GetAllCategoriesParent()
        {
            using (Model1 context = new Model1())
            {
                return context.CategoryParents.Select(categoryParent => categoryParent).ToList();
            }
        }

       
        public void UpdateCategoryParent(CategoryParent categoryParent)
        {
            using (Model1 context = new Model1())
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