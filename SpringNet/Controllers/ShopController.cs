using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SpringNet.Service;
using SpringNet.Models;

namespace SpringNet.Controllers
{
    public class ShopController : Controller
    {

        public IShopService ShopService { get; set; }
        //
        // GET: /Shop/

        public ActionResult Index()
        {
            //retorna la lista de todas las tiendas
            return View(ShopService.getAllShops());
        }

        //
        // GET: /Shop/Details/5

        public ActionResult Details(int id)
        {
            return View(ShopService.getShopById(id));
        }

        //
        // GET: /Shop/Create

        public ActionResult Create()
        {
            return View(new Shop());
        } 

        //
        // POST: /Shop/Create

        [HttpPost]
        public ActionResult Create(Shop shop)
        {
            try
            {
                ShopService.save(shop);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Shop/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View(ShopService.getShopById(id));
        }

        //
        // POST: /Shop/Edit/5

        [HttpPost]
        public ActionResult Edit(Shop shop, int id)
        {
            try
            {
                ShopService.update(shop, id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Shop/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View(ShopService.getShopById(id));
        }

        //
        // POST: /Shop/Delete/5

        [HttpPost]
        public ActionResult Delete(Shop shop, int id)
        {
            try
            {
                ShopService.delete(ShopService.getShopById(id));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
