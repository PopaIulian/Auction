using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuctionManagement.DataMapper;
using AuctionManagement.DomainModel;
using AuctionManagement.DomainModel.Validator;
using FluentValidation.Results;

namespace AuctionManagement.Services.ServicesImplementation
{
    class CategoryParentServices : ICategoryParentServices
    {

        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(CategoryParentServices));

       
        public static ICategoryParentDataServices DataServices { get; set; } = DaoFactoryMethod.CurrentDAOFactory.CategoryParentDataServices;


        public bool AddCategoryParent(CategoryParent categoryParent)
        {
            var validator = new CategoryParentValidator();
            ValidationResult results = validator.Validate(categoryParent);

            bool isValid = results.IsValid;

            if (isValid)
            {
                Log.Info("The category parent is valid!");
                DataServices.AddCategoryParent(categoryParent);
                Log.Info("The category parent was added to the database!");
            }
            else
            {
                IList<ValidationFailure> failures = results.Errors;
                Log.Error($"The category is not valid. The following errors occurred: {failures}");
            }

            return isValid;
        }

        public bool DeleteCategoryParent(CategoryParent categoryParent)
        {
            var validator = new CategoryParentValidator();
            ValidationResult results = validator.Validate(categoryParent);

            bool isValid = results.IsValid;

            if (isValid)
            {
                Log.Info("The category parent is valid!");
                DataServices.DeleteCategoryParent(categoryParent);
                Log.Info("The category parent was added to the database!");
            }
            else
            {
                IList<ValidationFailure> failures = results.Errors;
                Log.Error($"The category is not valid. The following errors occurred: {failures}");
            }

            return isValid;
        }

        public CategoryParent GetCategoryParentById(int id)
        {
            return DataServices.GetCategoryParentById(id);
        }

        public IList<CategoryParent> GetListOfCategories()
        {
            return DataServices.GetAllCategoriesParent();
        }

        public bool UpdateCategoryParent(CategoryParent categoryParent)
        {
            var validator = new CategoryParentValidator();
            ValidationResult results = validator.Validate(categoryParent);

            bool isValid = results.IsValid;

            if (isValid)
            {
                Log.Info("The category parent is valid!");
                DataServices.UpdateCategoryParent(categoryParent);
                Log.Info("The category parent was added to the database!");
            }
            else
            {
                IList<ValidationFailure> failures = results.Errors;
                Log.Error($"The category is not valid. The following errors occurred: {failures}");
            }

            return isValid;
        }
    }
}
