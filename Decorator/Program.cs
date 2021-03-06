﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            string str  = "charles";
            ISave savingObject = new Save();
            ILog loggingObject = new Log();
            IMessage messageObject = new Message();

            savingObject.save(str);
            Console.ReadLine();

            loggingObject.log(str);
            Console.ReadLine();

            messageObject.displayMessage(str);
            Console.ReadLine();


            ISave savingWithLoggingDecorator = new SaveWithLoggingDecorator(savingObject, loggingObject);
            savingWithLoggingDecorator.save(str);
            Console.ReadLine();


            ISave savingWithLoggingAndMessagingDecorator = new SaveWithMessageDecorator(savingWithLoggingDecorator, messageObject);       
            savingWithLoggingAndMessagingDecorator.save(str);
            Console.ReadLine();
        }
    }
}
