// <copyright file="IProductServices.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.Services
{
    using System.Collections.Generic;
    using AuctionManagement.DomainModel;

    /// <summary>
    /// Defines the <see cref="IProductServices" />.
    /// </summary>
    public interface IProductServices
    {
        /// <summary>
        /// The AddProduct.
        /// </summary>
        /// <param name="product">The product<see cref="Product"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        bool AddProduct(Product product);

        /// <summary>
        /// The GetProductById.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="Product"/>.</returns>
        Product GetProductById(int id);

        /// <summary>
        /// The GetListOfProducts.
        /// </summary>
        /// <returns>The <see cref="IList{Product}"/>.</returns>
        IList<Product> GetListOfProducts();

        /// <summary>
        /// The UpdateProduct.
        /// </summary>
        /// <param name="product">The product<see cref="Product"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        bool UpdateProduct(Product product);

        /// <summary>
        /// The DeleteProduct.
        /// </summary>
        /// <param name="product">The product<see cref="Product"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        bool DeleteProduct(Product product);
    }
}
