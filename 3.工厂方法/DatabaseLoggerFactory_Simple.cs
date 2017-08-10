using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.工厂方法
{
    public class DatabaseLoggerFactory_Simple : LoggerFactory_Simple
    {
        protected override ILogger CreateLogger()
        {
            ILogger logger = new DatabaseLogger();
            // 初始化数据库日志记录器，代码省略
            return logger;
        }
    }
}