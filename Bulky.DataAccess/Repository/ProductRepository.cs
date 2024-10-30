using BulkyBook.DataAccess.Data;
using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace BulkyBook.DataAccess.Repository

{
    public class ProductRepository : Repository<Product>, IProductReopsitory
    {
        ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            this._db = db;
        }

        

        public void Update(Product product)
        {
            _db.Products.Update(product);
           
        }

       
    }
}
