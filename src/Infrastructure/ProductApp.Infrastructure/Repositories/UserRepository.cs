using ProductApp.Data;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductApp.Infrastructure.Abstract;

namespace ProductApp.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ProductDBContext _context;

        public UserRepository(ProductDBContext context)
        {
            _context = context;
        }

        public async Task<User> GetByIdAsync(Guid id)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Id == id && !u.IsDeleted);
        }

        public async Task<User> GetByNameAsync(string name)
        {
            return await _context.Users
                .Where(u => !u.IsDeleted)
                .FirstOrDefaultAsync(u => u.FirstName == name || u.LastName == name);
        }

        public async Task CreateAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var user = await GetByIdAsync(id);
            if (user != null)
            {
                user.IsDeleted = true;
                await UpdateAsync(user);
            }
        }
    }
}
