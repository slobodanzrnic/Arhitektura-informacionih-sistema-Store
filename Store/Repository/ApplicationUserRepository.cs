using Store.Data;
using Store.Models;
using Store.Repository.IRepository;
using System.Linq.Expressions;

namespace Store.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private ApplicationDbContext _db;
        public ApplicationUserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
            
        }
        
    }
}
