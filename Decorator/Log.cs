using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Composer
{
    public class Log : ILog
    {
        public void log(string str)
        {
            Console.WriteLine(".......logging: " + str);
        }
    }
}
