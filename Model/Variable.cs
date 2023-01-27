using Microsoft.VisualBasic;

namespace ConsoleApp27.Model
{
    internal class Variable:EntityBase
    {
        public string? Name { get; set; }
        public IEnumerable<TemplateMessage>? TemplateMessages { get; set; }
        public User? User { get; set; }
        public IEnumerable<Value>? Values { get; set; }
        public VariableType? VariableType { get; set; }

    

    }
}