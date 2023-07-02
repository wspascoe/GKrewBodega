﻿using GKrewBodega.DataAccess.Repository.IRepository;
using GKrewBodega.Models;
using GKrewBodegaWeb.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GKrewBodega.DataAccess.Repository
{
    public class ShoppingCartRepository : Repository<ShoppingCart>, IShoppingCartRepository
    {
        private ApplicationDbContext _db;

        public ShoppingCartRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public int DecrementCount(ShoppingCart cart, int count)
        {
            cart.Count -= count;
            return cart.Count;
        }

        public int IncrementCount(ShoppingCart cart, int count)
        {
            cart.Count += count;
            return cart.Count;
        }
    }
}
