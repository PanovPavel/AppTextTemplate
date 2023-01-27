// See https://aka.ms/new-console-template for more information
using ConsoleApp27.Model;
using ConsoleApp30;
ApplicationContext context = new ApplicationContext();

TemplateMessage message = new TemplateMessage();
message.RawText = "Какой-то рандомный не понятный текст";

Variable variable = new Variable();
variable.TemplateMessages = (IEnumerable<TemplateMessage>)message;
