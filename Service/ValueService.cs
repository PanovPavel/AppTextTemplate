using ConsoleApp27.Model;
using ConsoleApp30;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27.Service
{
    internal class ValueService
    {
        ApplicationContext context = new ApplicationContext();

        public int Add(Value t)
        {
            throw new NotImplementedException();
        }

        public Task<int> AddAsync(Value t)
        {
            throw new NotImplementedException();
        }

        public Task DeletaAsync(Value t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Value t)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Value> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Value>> GetByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Value> GetList()
        {
            throw new NotImplementedException();
        }

        public Task<List<Value>> GetListAsync()
        {
            throw new NotImplementedException();
        }

        public int Update(Value t)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(Value t)
        {
            throw new NotImplementedException();
        }
    }
}
