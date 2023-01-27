using ConsoleApp27.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27.Service
{
    internal interface IService<T>
    {
        public Task<List<T>> GetUserListAsync();
        public Task<IEnumerable<T>> GetUserByIdAsync(int Id);
        public Task<int> AddUserAsync(T t);
        public Task<int> UpdateUserAsync(T t);
    }
}
