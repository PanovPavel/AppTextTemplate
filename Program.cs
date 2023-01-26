// See https://aka.ms/new-console-template for more information
using ConsoleApp27.Model;
using ConsoleApp30;
using ConsoleApp30.DAO;
ApplicationContext context = new ApplicationContext();
User user = new User();
context.Add(user);
var listUsers = context.Users.ToList();
context.SaveChanges();