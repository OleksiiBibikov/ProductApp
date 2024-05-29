using Microsoft.EntityFrameworkCore;
using ProductApp.Data;
using ProductApp.Infrastructure.Abstract;

namespace ProductApp.Infrastructure.Repositories
{
    public class ProductRepository : Repository<Product>
    {
        public ProductRepository(ProductDBContext productDBContext) : base(productDBContext)
        {
            
        }

        public override async Task Create(Product entity)
        {
            await DBContext.Products.AddAsync(entity);
            await SaveAsync();
        }

        public override async Task Delete(Guid id)
        {
            var entity = await GetById(id);
            DBContext.Products.Remove(entity);

            await SaveAsync();
        }

        public override IQueryable<Product> GetAll()
        {
            return DBContext.Products.AsNoTracking();
        }

        public override async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await Task.Run(() => { return GetAll(); });
        }

        public override async Task<Product> GetById(Guid id)
        {
            return await DBContext.Products.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
        }

        public override async Task Update(Guid id, Product entity)
        {
            var entityOld = await GetById(id);

            if (entityOld != null)
            {
                DBContext.Products.Update(entity);
                await SaveAsync();
            }           
        }
    }
}
