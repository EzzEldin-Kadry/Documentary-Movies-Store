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
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDBContext db) : base(db)
        {
        }

        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }
    }
}
