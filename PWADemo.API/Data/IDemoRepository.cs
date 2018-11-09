using System.Collections.Generic;
using System.Threading.Tasks;
using PWADemo.API.Models;

namespace PWADemo.API.Data
{
    public interface IDemoRepository
    {
         void Add<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;
        Task<bool> SaveAllAsync();
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUser(int id);
    }
}