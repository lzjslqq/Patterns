using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.工厂方法
{
    public abstract class LoggerFactory_Simple
    {
        // 在工厂类中直接调用日志记录器的业务方法WriteLog()
        public void WriteLog()
        {
            ILogger logger = this.CreateLogger();
            logger.WriteLog();
        }

        protected abstract ILogger CreateLogger();
    }
}