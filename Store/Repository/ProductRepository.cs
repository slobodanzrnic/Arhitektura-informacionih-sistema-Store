using Microsoft.EntityFrameworkCore;
using Store.Data;
using Store.Models;
using Store.Repository.IRepository;
using System.Linq.Expressions;

namespace Store.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
            
        }
        

        public void Update(Product obj)
        {
            var objFromDb = _db.Products.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = obj.Name;
                objFromDb.Description = obj.Description;
                objFromDb.Manufacturer = obj.Manufacturer;
                objFromDb.Price = obj.Price;
                objFromDb.Price2 = obj.Price2;
                objFromDb.Price3 = obj.Price3;
                objFromDb.CategoryId = obj.CategoryId;
                if (obj.ImageUrl != null)
                {
                    objFromDb.ImageUrl = obj.ImageUrl;
                }
            }
        }
    }
}
