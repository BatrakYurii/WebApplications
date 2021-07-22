﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplications.Models;

namespace WebApplications.Services
{
    public interface IShopService
    {
        public IEnumerable<Shop> GetAll();
        public void Delete(int id);
        public void Post(Shop shop);
    }
}
