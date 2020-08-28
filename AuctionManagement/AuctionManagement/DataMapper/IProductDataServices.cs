

namespace AuctionManagement.DataMapper
{
    using AuctionManagement.DomainModel;
    using System.Collections.Generic;

    public interface IProductDataServices
    {
        void AddObject(Product product);

        Product GetObjectById(int id);

        IList<Product> GettAllObjects();

        void UpdateObject(Product product);

        void DeleteObject(Product product);
    }
}
