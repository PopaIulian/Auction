// <copyright file="SqlProductDataServices.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.DataMapper.SqlServerDAO
{
    using System.Collections.Generic;
    using System.Linq;
    using AuctionManagement.DomainModel;

    /// <summary>
    /// Defines the <see cref="SqlProductDataServices" />.
    /// </summary>
    internal class SqlProductDataServices : IProductDataServices
    {
        /// <summary>
        /// The AddObject.
        /// </summary>
        /// <param name="product">The product<see cref="Product"/>.</param>
        public void AddObject(Product product)
        {
            using (Model1 context = new Model1())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// The DeleteObject.
        /// </summary>
        /// <param name="product">The product<see cref="Product"/>.</param>
        public void DeleteObject(Product product)
        {
            using (Model1 context = new Model1())
            {
                Product toBeDeleted = new Product { IdProduct = product.IdProduct };
                context.Products.Attach(toBeDeleted);
                context.Products.Remove(toBeDeleted);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// The GetObjectById.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="Product"/>.</returns>
        public Product GetObjectById(int id)
        {
            using (Model1 context = new Model1())
            {
                return context.Products.Where(product => product.IdProduct == id).SingleOrDefault();
            }
        }

        /// <summary>
        /// The GetAllObjects.
        /// </summary>
        /// <returns>The <see cref="IList{Product}"/>.</returns>
        public IList<Product> GetAllObjects()
        {
            using (Model1 context = new Model1())
            {
                return context.Products.Select(product => product).ToList();
            }
        }

        /// <summary>
        /// The UpdateObject.
        /// </summary>
        /// <param name="product">The product<see cref="Product"/>.</param>
        public void UpdateObject(Product product)
        {
            using (Model1 context = new Model1())
            {
                Product toBeUpdated = context.Products.Find(product.IdProduct);

                if (toBeUpdated != null)
                {
                    context.Entry(toBeUpdated).CurrentValues.SetValues(product);
                    context.SaveChanges();
                }
            }
        }
    }
}
