﻿

namespace AuctionManagement.Services.ServicesImplementation
{
    using System.Collections.Generic;
    using AuctionManagement.DataMapper;
    using AuctionManagement.DomainModel;

    class CategoryServices :ICategoryServices
    {
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(CategoryServices));

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
            return DataServices.GetAllCategories();
        }

        public bool UpdateCategory(Category category)
        {
            DataServices.UpdateCategory(category);
            return true;
        }

    }
}


