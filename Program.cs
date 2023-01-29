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
catch (Exception ex) { Console.WriteLine(ex.Message); }


var getUser = userService.GetUserById(Guid.Parse("2e686ab2-d8f9-4113-be75-0cb8c83cedd8"));
getUser.IsMailingAgreement = false;
getUser.IsBlocked = false;
userService.UpdateUser(getUser);

var users = userService.GetUsers();
foreach(var user in users)
{
    Console.WriteLine(user.ToString());
}
