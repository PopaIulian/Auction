// <copyright file="IProductDataServices.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.DataMapper
{
    using System.Collections.Generic;
    using AuctionManagement.DomainModel;

    /// <summary>
    /// Defines the <see cref="IProductDataServices" />.
    /// </summary>
    public interface IProductDataServices
    {
        /// <summary>
        /// The AddObject.
        /// </summary>
        /// <param name="product">The product<see cref="Product"/>.</param>
        void AddObject(Product product);

        /// <summary>
        /// The GetObjectById.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="Product"/>.</returns>
        Product GetObjectById(int id);

        /// <summary>
        /// The GetAllObjects.
        /// </summary>
        /// <returns>The <see cref="IList{Product}"/>.</returns>
        IList<Product> GetAllObjects();

        /// <summary>
        /// The UpdateObject.
        /// </summary>
        /// <param name="product">The product<see cref="Product"/>.</param>
        void UpdateObject(Product product);

        /// <summary>
        /// The DeleteObject.
        /// </summary>
        /// <param name="product">The product<see cref="Product"/>.</param>
        void DeleteObject(Product product);
    }
}
