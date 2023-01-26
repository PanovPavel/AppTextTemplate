using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp27.Model;

namespace ConsoleApp30.DAO
{
    internal interface IUserCRUD
    {
        void addUser(User user);
        void getUsers();
        void deleteUser(int id);
    }
}
