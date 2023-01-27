using Microsoft.VisualBasic;

namespace ConsoleApp27.Model
{
    internal class Value:EntityBase
    {
        public Guid VariableId { get; init; }
        public Variable? Variable { get; set; }
        public string? Text { get; set; }

        public Value() { 
            VariableId = Guid.NewGuid();
        }
    }
}