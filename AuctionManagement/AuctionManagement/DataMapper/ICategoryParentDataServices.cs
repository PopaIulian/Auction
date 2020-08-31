using AuctionManagement.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionManagement.DataMapper
{

    public interface ICategoryParentDataServices
    {

        void AddCategoryParent(CategoryParent categoryParent);


        CategoryParent GetCategoryParentById(int id);


        IList<CategoryParent> GetAllCategoriesParent();


        void UpdateCategoryParent(CategoryParent categoryParent);


        void DeleteCategoryParent(CategoryParent categoryParent);
    }
}

