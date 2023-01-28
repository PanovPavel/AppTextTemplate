using ConsoleApp27.Model;
using ConsoleApp30;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27.Service
{
    internal class VariableService : IService<Variable>
    {
        ApplicationContext context = new ApplicationContext();
    }
}
