// <copyright file="ProductServices.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

using AuctionManagement.DomainModel.Validator;
using FluentValidation.Results;

namespace AuctionManagement.Services.ServicesImplementation
{
    using AuctionManagement.DataMapper;
    using AuctionManagement.DomainModel;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="ProductServices" />.
    /// </summary>
    internal class ProductServices : IProductServices
    {

        /// <summary>
        /// Defines the Log.
        /// </summary>
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(ProductServices));

        /// <summary>
        /// Gets or sets the DataServices.
        /// </summary>
        public static IProductDataServices DataServices { get; set; } = DaoFactoryMethod.CurrentDAOFactory.ProductDataServices;

        /// <summary>
        /// The AddProduct.
        /// </summary>
        /// <param name="product">The product<see cref="Product"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool AddProduct(Product product)
        {
            var validator = new ProductValidator();
            ValidationResult results = validator.Validate(product);

            bool isValid = results.IsValid;

            if (isValid)
            {
                Log.Info("The auction is valid!");
                DataServices.AddObject(product);
                Log.Info("The auction was added to the database!");
            }
            else
            {
                IList<ValidationFailure> failures = results.Errors;
                Log.Error($"The auction is not valid. The following errors occurred: {failures}");
            }

            return isValid;
        }

        /// <summary>
        /// The DeleteProduct.
        /// </summary>
        /// <param name="product">The product<see cref="Product"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool DeleteProduct(Product product)
        {
            var validator = new ProductValidator();
            ValidationResult results = validator.Validate(product);

            bool isValid = results.IsValid;

            if (isValid)
            {
                Log.Info("The auction is valid!");
                DataServices.DeleteObject(product);
                Log.Info("The auction was deleted to the database!");
            }
            else
            {
                IList<ValidationFailure> failures = results.Errors;
                Log.Error($"The auction is not valid. The following errors occurred: {failures}");
            }

            return isValid;
        }

        /// <summary>
        /// The GetListOfProducts.
        /// </summary>
        /// <returns>The <see cref="IList{Product}"/>.</returns>
        public IList<Product> GetListOfProducts()
        {
            return DataServices.GetAllObjects();
        }

        /// <summary>
        /// The GetProductById.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="Product"/>.</returns>
        public Product GetProductById(int id)
        {
            return DataServices.GetObjectById(id);
        }

        /// <summary>
        /// The UpdateProduct.
        /// </summary>
        /// <param name="product">The product<see cref="Product"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool UpdateProduct(Product product)
        {
            var validator = new ProductValidator();
            ValidationResult results = validator.Validate(product);

            bool isValid = results.IsValid;

            if (isValid)
            {
                Log.Info("The auction is valid!");
                DataServices.UpdateObject(product);
                Log.Info("The auction was updated to the database!");
            }
            else
            {
                IList<ValidationFailure> failures = results.Errors;
                Log.Error($"The auction is not valid. The following errors occurred: {failures}");
            }

            return isValid;
        }
    }
}

