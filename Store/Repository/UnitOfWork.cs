using Store.Data;
using Store.Repository.IRepository;

namespace Store.Repository
{
    public class UnitOfWork : IUnitOfWork
    {

        private ApplicationDbContext _db;
        public ICategoryRepository Category { get; private set; }
        public ICompanyRepository Company { get; private set; }
        public IProductRepository Product { get; private set; }
        public IShoppingCartRepository ShoppingCart { get; private set; }
        public IApplicationUserRepository ApplicationUser { get; private set; }
        public IOrderDetailRepository OrderDetail { get; private set; }
        public IOrderHeaderRepository OrderHeader { get; private set; }
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            ApplicationUser = new ApplicationUserRepository(db);
            ShoppingCart = new ShoppingCartRepository(_db);
            Company = new CompanyRepository(_db);
            Category = new CategoryRepository(_db);
            Product = new ProductRepository(_db);
            OrderDetail = new OrderDetailRepository(_db);   
            OrderHeader = new OrderHeaderRepository(_db);
        }
        
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
