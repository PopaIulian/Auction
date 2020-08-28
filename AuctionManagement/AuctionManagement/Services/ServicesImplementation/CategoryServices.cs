using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionManagement.Services.ServicesImplementation
{
    using AuctionManagement.DataMapper;
    using AuctionManagement.DomainModel;

    class CategoryServices :ICategoryServices
    {
        ///private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(AuthorServices));

        public static ICategoryDataServices DataServices { get; set; } = DaoFactoryMethod.CurrentDAOFactory.CategoryDataServices;

        public bool AddCategory(Category category)
        {
            DataServices.AddCategory(category);
            return true;
        }

        public bool DeleteCategory(Category category)
        {
            DataServices.DeleteCategory(category);
            return true;
        }

        public Category GetCategoryById(int id)
        {
            return DataServices.GetCategoryById(id);
        }

        public IList<Category> GetListOfCategories()
        {
            return DataServices.GettAllCategories();
        }

        public bool UpdateCategory(Category category)
        {
            DataServices.UpdateCategory(category);
            return true;
        }

    }
}


