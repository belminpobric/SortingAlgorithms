using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class ConsoleLog : ILogger
    {
        public virtual void Write(string message)
        {
            Console.Write(message);
        }
    }
}
