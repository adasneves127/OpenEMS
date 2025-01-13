using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PluginBase
{
    public interface ICommand
    {
        string Name {get; }
        string Description {get; }
        int Execute();
    }
}