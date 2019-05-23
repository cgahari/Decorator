using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Message : IMessage
    {
        public void displayMessage(string str)
        {
            Console.WriteLine("*********************messaging : " + str + " **********************");
        }
    }
}
