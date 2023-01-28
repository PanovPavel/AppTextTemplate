using Microsoft.VisualBasic;

namespace ConsoleApp27.Model
{
    internal class VariableTag:EntityBase
    {
        public string? Name { get; set; }
        public IEnumerable<TemplateMessage>? TemplateMessages { get; set; }
        public User? User { get; set; }
        public Value? Values { get; set; }
    }
}
