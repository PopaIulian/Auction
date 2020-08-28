

namespace AuctionManagement.DataMapper
{
    using AuctionManagement.DomainModel;
    using System.Collections.Generic;

    public interface ICategoryDataServices
    {
        void AddCategory(Category category);

        Category GetCategoryById(int id);

        IList<Category> GettAllCategories();

        void UpdateCategory(Category category);

        void DeleteCategory(Category category);
    }
}
