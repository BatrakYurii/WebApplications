using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplications.Models;

namespace WebApplications.Services
{
    public class ShopService : IShopService
    {     
    
        List<Shop> shops = new List<Shop>()
        {
            new Shop { id=1,ShopName="FirstShop"} ,
            new Shop { id=2,ShopName="SecondShop",} ,
        };

        public IEnumerable<Shop> GetAll()
        {
            return shops;
            
        }
        public void Delete(int id)
        {
            shops.RemoveAll(e => e.id == id);
        }
        public void Post(Shop shop)
        {
            shops.Add(shop);
        }

        public Shop GetById(int id)
        {
            foreach(Shop shop in shops)
            {
                if (shop.id == id)
                    return shop;
            }
            return null;
        }
        public void Put(int deleteId, Shop shop)
        {
            shops.RemoveAll(e => e.id == deleteId);
            shop.id = deleteId;
            shops.Add(shop);

        }
    }
    
}

