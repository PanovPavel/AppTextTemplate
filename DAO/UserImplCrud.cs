using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp27.Model;

namespace ConsoleApp30.DAO
{
    internal class UserImplCrud : IUserCRUD
    {
        public async void addUser(User user)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                await db.Users.AddAsync(user);
                await db.SaveChangesAsync();
                Console.WriteLine("Объект сохранён" + user.ToString());
            }
        }
        public void getUsers() {
            using(ApplicationContext db = new ApplicationContext())
            {
                List<User> users= db.Users.ToList();
                Console.WriteLine("Объект получен\n");
                foreach (User user in users)
                {
                   Console.WriteLine( user.ToString());
                }
            }
        }
        public async void deleteUser(int id)
        {
            using(ApplicationContext db = new ApplicationContext())
            {
                User? user = db.Users.Find(id);
                if (user is null)
                {
                    db.Users.Remove(user);
                    await db.SaveChangesAsync();
                    Console.WriteLine("Удалён " + user.ToString());
                }
            }
        }
    }
}
