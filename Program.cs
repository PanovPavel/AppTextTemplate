// See https://aka.ms/new-console-template for more information
using ConsoleApp27.Model;
using ConsoleApp30;
ApplicationContext context = new ApplicationContext();

User user = new User();
user.UserName = "Антон";
user.Name = "Test2";
context.Users.Add(user);

User user2 = new User();
user2.UserName = "Антон2";
user2.Name = "Test2";
context.Users.Add(user2);

User user3 = new User();
user3.UserName = "Антон3";
user3.Name = "Test3";
context.Users.Add(user3);

User user4 = new User();
user4.UserName = "Антон4";
user4.Name = "Test4";
context.Users.Add(user4);
context.SaveChanges();

TemplateMessage templateMessage = new TemplateMessage();
templateMessage.RawText = "Какой-то старый текст";
templateMessage.User = user;
context.TemplateMessages.Add(templateMessage);

TemplateMessage templateMessage2 = new TemplateMessage();
templateMessage2.RawText = "Какой-то старый текст2";
templateMessage2.User = user3;
context.TemplateMessages.Add(templateMessage2);
context.SaveChanges();



