using ClassicM.DataAccess.Data;
using ClassicM.DataAccess.Repository.IRepository;
using ClassicM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicM.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDBContext db) : base(db)
        {
        }

        public void Update(Product product)
        {
            var objFromDb = _db.Products.FirstOrDefault(x => x.Id == product.Id);
            if(objFromDb is not null)
            {
                objFromDb.Title = product.Title;
                objFromDb.Description = product.Description;
                objFromDb.ReleasedDate = product.ReleasedDate;
                objFromDb.Director = product.Director;
                objFromDb.Company = product.Company;
                objFromDb.ListPrice = product.ListPrice;
                objFromDb.Price = product.Price;
                objFromDb.Price5 = product.Price5;
                objFromDb.Price10 = product.Price10;
                objFromDb.CategoryId = product.CategoryId;
                objFromDb.CoverTypeId = product.CoverTypeId;
                if (product.ImageUrl is not null)
                    objFromDb.ImageUrl = product.ImageUrl;
            }
        }
    }
}
