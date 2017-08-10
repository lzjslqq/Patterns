using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.工厂方法
{
    /// <summary>
    /// 具体工厂--文件日志工厂
    /// </summary>
    public class FileLoggerFactory : ILoggerFactory
    {
        public ILogger CreatLogger()
        {
            ILogger logger = new FileLogger();
            return logger;
        }
    }
}