using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShutdownWinForm.Classes.Commands
{
    public class InterpretorCommands
    {
       public Dictionary<string, object> SepereateCommand(string Commands)
        {
            Dictionary<string,object> result = new Dictionary<string,object>();
            char[] sepereator = { '-' };
            string [] seperatorValues = Commands.Split(sepereator);

            result.Add(seperatorValues[0], seperatorValues[1]);
            return result;
        }
    }
}
