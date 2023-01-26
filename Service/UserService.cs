using ConsoleApp27.Model;
using ConsoleApp30;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27.Service
{
    internal class UserService : IUserService
    {
        private ApplicationContext applicationContext;
        public Task<int> AddUserAsync(User user)
        {
            
            throw new NotImplementedException();
        }

        public Task<int> DeleteUserAsync(int Id)
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

        public Task<int> UpdateUserAsync(User User)
        {
            throw new NotImplementedException();
        }
    }
}
