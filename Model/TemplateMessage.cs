using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27.Model
{
    internal class TemplateMessage : EntityBase
    {
        public string? RawText { get; set; }
        public User? User { get; set; }
        public IEnumerable<Variable>? Variables { get; set; }

    }
}
