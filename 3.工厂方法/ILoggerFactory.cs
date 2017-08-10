using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.工厂方法
{
    /// <summary>
    /// 抽象工厂
    /// </summary>
    public interface ILoggerFactory
    {
        ILogger CreatLogger();
    }
}