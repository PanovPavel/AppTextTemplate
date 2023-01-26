using ConsoleApp27.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27.Service
{
    internal interface IUserService
    {
        public Task<List<User>> GetUserListAsync();
        public Task<IEnumerable<User>> GetUserByIdAsync(int Id);
        public Task<int> AddUserAsync(User user);
        public Task<int> UpdateUserAsync(User User);
    }
}
