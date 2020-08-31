// <copyright file="ProductServices.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.Services.ServicesImplementation
{
    using AuctionManagement.DomainModel;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="ProductServices" />.
    /// </summary>
    internal class ProductServices : IProductServices
    {
        /// <summary>
        /// The AddProduct.
        /// </summary>
        /// <param name="product">The product<see cref="Product"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool AddProduct(Product product)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// The DeleteProduct.
        /// </summary>
        /// <param name="product">The product<see cref="Product"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool DeleteProduct(Product product)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// The GetListOfProducts.
        /// </summary>
        /// <returns>The <see cref="IList{Product}"/>.</returns>
        public IList<Product> GetListOfProducts()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// The GetProductById.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="Product"/>.</returns>
        public Product GetProductById(int id)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// The UpdateProduct.
        /// </summary>
        /// <param name="product">The product<see cref="Product"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool UpdateProduct(Product product)
        {
            throw new System.NotImplementedException();
        }
    }
}
