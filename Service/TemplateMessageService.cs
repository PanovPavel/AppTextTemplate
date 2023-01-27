using ConsoleApp27.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27.Service
{
    internal class TemplateMessageService : IService<TemplateMessage>
    {
        public Task<int> AddUserAsync(TemplateMessage t)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TemplateMessage>> GetUserByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<TemplateMessage>> GetUserListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateUserAsync(TemplateMessage t)
        {
            throw new NotImplementedException();
        }
    }
}
