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
    //TODO: Реализовать через интерфейс
    //TODO: Сделать Task обёртку
    //TODO: Написать собственные исключения
    //HACK: какой-то короткоживущий applucationn
    internal class UserService
    {
        //HACK: какой-то короткоживущий applucationn
        public Guid Add(User user)
        {
            using (var applicationContext = new ApplicationContext())
            {
                if (user is not null)
                {
                    applicationContext.Users.Add(user);
                    applicationContext.SaveChanges();
                    return user.Id;
                }else
                {
                    //HACK:
                    throw new NullReferenceException("user == null");
                }
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
            try
            {
                using (var applicationContext = new ApplicationContext())
                {
                    var getedUser = (from user in applicationContext.Users
                                     where user.Id == id
                                     select user
                                ).First();
                    return getedUser;
                }
            }
            catch
            {
                //HACK: 
                throw new InvalidOperationException("not find user ID: " + id);
            }
        }
        public Guid DeleteUserById(Guid id)
        {
            using(var applicationContext = new ApplicationContext())
            {
                try
                {
                    var userRemoved = (from user in applicationContext.Users
                                       where user.Id == id
                                       select user
                    ).First();
                    applicationContext.Users.Remove(userRemoved);
                    applicationContext.SaveChanges();
                    return userRemoved.Id;
                }
                catch
                {
                    //HACK: 
                    throw new InvalidOperationException("not find user ID" + id);
                }
            }
        }
        public Guid UpdateUser(User user)
        {
            using (ApplicationContext applicationContext = new ApplicationContext())
            {
                if (user != null)
                {
                    applicationContext.Users.Update(user);
                    applicationContext.SaveChanges();
                    return user.Id;
                }
                else
                {
                    //HACK:
                    throw new NullReferenceException("user = null");
                }
            }
        }
    }
}
