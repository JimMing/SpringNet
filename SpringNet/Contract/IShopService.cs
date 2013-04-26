using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpringNet.Models;
using SpringNet.Domain;

namespace SpringNet.Service
{
    public interface IShopService
    {
        IList<Shop> getAllShops();
        Shop getShopById(int id);
        void save(Shop shop);
        void delete(Shop shop);
        void update(Shop shop, int id);
    }
}
