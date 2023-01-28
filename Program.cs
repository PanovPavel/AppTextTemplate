// See https://aka.ms/new-console-template for more information
using ConsoleApp27.Model;
using ConsoleApp27.Service;
using ConsoleApp30;

UserService userService = new UserService();

userService.Add(new User() { Name = "Иванов", UserName = "Иван"});
userService.Add(new User() { Name = "Антон", UserName = "Власов" });





var users = userService.GetUsers();
foreach(var user in users)
{
    Console.WriteLine($"id {user.Id} name: {user.Name} userName: {user.UserName}");
}
