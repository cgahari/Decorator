using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Save : ISave
    {
        public void save(string str)
        {
            Console.WriteLine(".......saving: " + str);
        }
    }
}
