using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Composer
{
    public class SaveWithMessageDecorator : ISave
    {
        ISave _save;
        IMessage _message;
        public SaveWithMessageDecorator(ISave save, IMessage message)
        {
            _save = save;
            _message = message;
        }
        public void save(string str)
        {
           _save.save(str);
            _message.displayMessage(str);
        }
    }
}
