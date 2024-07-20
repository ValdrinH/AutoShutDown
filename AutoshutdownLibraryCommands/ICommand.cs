using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoshutdownLibraryCommands
{
    internal interface ICommand
    {
        string _CommandName { get; set; }
        object _CommandValue { get; set; }
    }
}
