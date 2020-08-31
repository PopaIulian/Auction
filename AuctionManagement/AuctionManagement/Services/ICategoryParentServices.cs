

namespace AuctionManagement.Services
{
    using System.Collections.Generic;
    using AuctionManagement.DomainModel;

    interface ICategoryParentServices
    {
        bool AddCategoryParent(CategoryParent categoryParent);

        CategoryParent GetCategoryParentById(int id);

        IList<CategoryParent> GetListOfCategories();

        bool UpdateCategoryParent(CategoryParent categoryParent);

        bool DeleteCategoryParent(CategoryParent categoryParent);
    }
}
