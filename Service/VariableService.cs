using ConsoleApp27.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27.Service
{
    internal class VariableService : IService<Variable>
    {
        public Task<int> AddUserAsync(Variable t)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Variable>> GetUserByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Variable>> GetUserListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateUserAsync(Variable t)
        {
            throw new NotImplementedException();
        }
    }
}
