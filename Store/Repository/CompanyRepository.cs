using Store.Data;
using Store.Models;
using Store.Repository.IRepository;
using System.Linq.Expressions;

namespace Store.Repository
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        private ApplicationDbContext _db;
        public CompanyRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
            
        }
        

        public void Update(Company obj)
        {
            _db.Companies.Update(obj);
        }
    }
}
