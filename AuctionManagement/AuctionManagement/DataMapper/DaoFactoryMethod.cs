using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionManagement.DataMapper
{

    using AuctionManagement.DataMapper.SqlServerDAO;

    class DaoFactoryMethod
    {
        public static IDaoFactory CurrentDAOFactory
        {
            get
            {
                return new SqlServerDaoFactory();
            }
        }
    }
}



