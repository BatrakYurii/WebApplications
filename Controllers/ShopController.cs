using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplications.Models;
using WebApplications.Services;

namespace WebApplications.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopController : ControllerBase
    {
        private readonly IShopService _shopService;
        public ShopController(IShopService shopService)
        {
            _shopService = shopService;
        }

        [HttpGet]
        public IEnumerable<Shop> GetAll()
        {
            return _shopService.GetAll();
        }
        [HttpGet]
        [Route("{id}")]
        public Shop GetById(int id)
        {
            return _shopService.GetById(id);
        }
        [HttpDelete]
        [Route("{id}")]
        public void Delete(int id)
        {
            _shopService.Delete(id);
        }
        [HttpPost]
        public void Post(Shop shop)
        {
            _shopService.Post(shop);
        }
        [HttpPut]
        public void Put(int id, Shop shop)
        {
            _shopService.Put(id, shop);
        }
    }
}
