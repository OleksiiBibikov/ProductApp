using Microsoft.EntityFrameworkCore;
using ProductApp.Data;
using ProductApp.Infrastructure.Abstract;

namespace ProductApp.Infrastructure.Repositories
{
    public class ProviderRepository : Repository<Provider>
    {
        public ProviderRepository(ProductDBContext productDBContext) : base(productDBContext)
        {

        }

        public override async Task Create(Provider entity)
        {
            await DBContext.Providers.AddAsync(entity);
            await SaveAsync();
        }

        public override async Task Delete(Guid id)
        {
            var entity = await GetById(id);
            DBContext.Providers.Remove(entity);

            await SaveAsync();
        }

        public override IQueryable<Provider> GetAll()
        {
            return DBContext.Providers.AsNoTracking();
        }

        public override async Task<IEnumerable<Provider>> GetAllAsync()
        {
            return await Task.Run(() => { return GetAll(); });
        }

        public override async Task<Provider> GetById(Guid id)
        {
            return await DBContext.Providers.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
        }

        public override async Task Update(Guid id, Provider entity)
        {
            var entityOld = await GetById(id);

            if (entityOld != null)
            {
                DBContext.Providers.Update(entity);
                await SaveAsync();
            }
        }

    }   
}
