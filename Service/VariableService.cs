using ConsoleApp27.Model;
using ConsoleApp30;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27.Service
{
    internal class VariableService
    {
        ApplicationContext context = new ApplicationContext();

        public int Add(VariableTag t)
        {
            throw new NotImplementedException();
        }

        public Task<int> AddAsync(VariableTag t)
        {
            throw new NotImplementedException();
        }

        public Task DeletaAsync(VariableTag t)
        {
            throw new NotImplementedException();
        }

        public void Delete(VariableTag t)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VariableTag> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<VariableTag>> GetByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public List<VariableTag> GetList()
        {
            throw new NotImplementedException();
        }

        public Task<List<VariableTag>> GetListAsync()
        {
            throw new NotImplementedException();
        }

        public int Update(VariableTag t)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(VariableTag t)
        {
            throw new NotImplementedException();
        }
    }
}
