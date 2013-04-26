using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate;
using SpringNet.Domain;
using SpringNet.Models;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;
using Spring.Transaction;

namespace SpringNet.Service
{
    public class ShopService : IShopService
    {
        public ISessionFactory SessionFactory { get; set; }

        public IList<Shop> getAllShops()
        {
            return SessionFactory.GetCurrentSession().CreateCriteria<Shop>().List<Shop>().OrderByDescending(p => p.name).ToList<Shop>();
        }

        public Shop getShopById(int id)
        {
            return SessionFactory.GetCurrentSession().Get<Shop>(id);
        }

        public void save(Shop shop)
        {
            SessionFactory.GetCurrentSession().Save(shop);
        }

        public void delete(Shop shop)
        {
            SessionFactory.GetCurrentSession().Delete(shop);
            SessionFactory.GetCurrentSession().Flush();
        }

        public void update(Shop shop, int id)
        {
            SessionFactory.GetCurrentSession().Update(shop);
            //Muy importante realizar el flush
            SessionFactory.GetCurrentSession().Flush();
        }
    }
}