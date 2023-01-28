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
        public Task<List<T>> GetListAsync();
        public Task<IEnumerable<T>> GetByIdAsync(int Id);
        public Task<int> AddAsync(T t);
        public Task<int> UpdateAsync(T t);
        public Task DeletaAsync(T t);

        public List<T> GetList();
        public IEnumerable<T> GetById(int Id);
        public int Add(T t);
        public int Update(T t);
        public void Delete(T t);

    }
}
