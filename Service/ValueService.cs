using ConsoleApp27.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27.Service
{
    internal class ValueService : IService<Value>
    {
        public Task<int> AddUserAsync(Value t)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Value>> GetUserByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Value>> GetUserListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateUserAsync(Value t)
        {
            throw new NotImplementedException();
        }
    }
}
