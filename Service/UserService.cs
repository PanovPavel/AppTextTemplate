using ConsoleApp27.Model;
using ConsoleApp30;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27.Service
{
    //TODO: Реализовать функции интерфейса
    internal class UserService : IService<User>
    {
        private ApplicationContext applicationContext;

        public Task<int> AddUserAsync(User t)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetUserByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetUserListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateUserAsync(User t)
        {
            throw new NotImplementedException();
        }
    }
}
