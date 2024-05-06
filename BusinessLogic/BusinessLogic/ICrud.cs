using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.CRUD
{
    internal interface ICrud<T>
    {
        Task<bool> CreateAsync(T entity);
        Task<T> GetOneAsync(int id);
        Task<List<T>> GetAllAsync();
        Task<bool> UpdateAsync(T entity);
        Task<bool> DeleteAsync(int idToDelete);
    }
}
