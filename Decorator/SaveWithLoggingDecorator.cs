using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Composer
{
    public class SaveWithLoggingDecorator : ISave
    {
        ISave _save;
        ILog _log;

        public SaveWithLoggingDecorator(ISave save, ILog log)
        {
            _save = save;
            _log = log;

        }

        public void save(string str)
        {
            _save.save(str);
            _log.log(str);
        }
    }
}
