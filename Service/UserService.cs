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
    internal class UserService
    {
        //HACK: какой-то короткоживущий applucationn
        public Guid Add(User user)
        {
            using (var applicationContext = new ApplicationContext())
            {
                applicationContext.Users.Add(user);
                applicationContext.SaveChanges();
                return user.Id;
            }
        }
        public IEnumerable<User> GetUsers()
        {
            using(var applicationContext = new ApplicationContext())
            {
                var users = (from user in applicationContext.Users
                             select user
                             ).ToList<User>();
                   return users;

            }
        }
        public User GetUserById(Guid id)
        {
            using(var applicationContext = new ApplicationContext())
            {
                var getedUser = (from user in applicationContext.Users
                            where user.Id == id
                            select user
                            ).First();
                return getedUser;
            }
        }
        public Guid DeleteUserById(Guid id)
        {
            using(var applicationContext = new ApplicationContext())
            {
                var userRemoved = (from user in applicationContext.Users
                                 where user.Id == id
                                 select user
                ).First();
                applicationContext.Users.Remove(userRemoved);
                return userRemoved.Id;
            }
        }
        public Guid UpdateUser(User user)
        {
            using (ApplicationContext applicationContext = new ApplicationContext())
            {
                if (user != null)
                {
                    applicationContext.Users.Update(user);
                    return user.Id;
                }
                else
                {
                    //HACK:
                    throw new Exception("user = null");
                }
            }
        }
    }
}
