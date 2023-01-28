using ConsoleApp27.Model;
using ConsoleApp30;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27.Service
{
    //TODO: Реализовать функции интерфейса
    internal class UserService : IService<User>
    {
        private ApplicationContext applicationContext = new ApplicationContext();

        public int Add(User t)
        {
            throw new NotImplementedException();
        }
        public List<User> GetList()
        {
            throw new NotImplementedException();
        }
        public IEnumerable<User> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public int Update(User t)
        {
            throw new NotImplementedException();
        }

        public async Task<int> AddAsync(User t)
        {
            return await Task.Run(() => Add(t));
        }
        public async Task<int> UpdateAsync(User t)
        {
            return await Task.Run(() => Update(t));
        }
        public async Task<List<User>> GetListAsync()
        {
            return await Task.Run(() => GetList());
        }
        public async Task<IEnumerable<User>> GetByIdAsync(int Id)
        {
            return await Task.Run(() => GetById(Id));
        }
        public Task DeletaAsync(User t)
        {
            throw new NotImplementedException();
        }

        public void Delete(User t)
        {
            throw new NotImplementedException();
        }
    }
}
