using ProductApp.Data;
using System;
using System.Threading.Tasks;

namespace ProductApp.Infrastructure.Abstract
{
    public interface IUserRepository
    {
        Task<User> GetByIdAsync(Guid id);
        Task<User> GetByNameAsync(string name);
        Task CreateAsync(User user);
        Task UpdateAsync(User user);
        Task DeleteAsync(Guid id);
    }
}
