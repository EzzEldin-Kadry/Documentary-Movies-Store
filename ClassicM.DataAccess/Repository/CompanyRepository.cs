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
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        public CompanyRepository(ApplicationDBContext db) : base(db)
        {
        }

        public void Update(Company company)
        {
            _db.Companies.Update(company);
        }
    }
}
