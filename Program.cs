// See https://aka.ms/new-console-template for more information
using ConsoleApp27.Model;
using ConsoleApp27.Service;
using ConsoleApp30;

UserService userService = new UserService();

//userService.Add(new User() { Name = "Иванов", UserName = "Иван"});
//userService.Add(new User() { Name = "Антон", UserName = "Власов" });

try
{
    userService.DeleteUserById(Guid.Parse("479b67a0-5b4f-42d0-b323-eddb3d67ac27"));
}


var users = userService.GetUsers();
foreach(var user in users)
{
    Console.WriteLine(user.ToString());
}
