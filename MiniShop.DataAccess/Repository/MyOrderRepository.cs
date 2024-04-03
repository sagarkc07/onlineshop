﻿using MiniShop.DataAccess.Data;
using MiniShop.DataAccess.Repository.IRepository;
using MiniShop.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.DataAccess.Repository
{
    public class MyOrderRepository : Repository<Order>, IMyOrderRepository
    {
        private readonly ApplicationDbContext _db;
        public MyOrderRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;

        }


        public void Update(Order obj)
        {
            _db.Orders.Update(obj);
        }
    }
}
