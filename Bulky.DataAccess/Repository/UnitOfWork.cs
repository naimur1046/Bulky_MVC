﻿using BulkyBook.DataAccess.Data;
using BulkyBook.DataAccess.Repository.IRepository;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {

        ApplicationDbContext _db;
        public ICategoryRepository Category { get; private set; }
        public IProductReopsitory Product {  get; private set; }

      

        public UnitOfWork(ApplicationDbContext db) 
        {
            this._db = db;
            Category= new CategoryRepository(db);
            Product= new ProductRepository(db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

      
    }
}
