using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.工厂方法
{
    /*
     *     M公司欲开发一个系统运行日志记录器（Logger），该记录器可以通过多种途径保存系统的运行日志，例如通过文件记录或数据库记录，用户可以通过修改配置文件灵活地更换日志记录方式。在设计各类日志记录器时，M公司的开发人员发现需要对日志记录器进行一些初始化工作，初始化参数的摄制过程比较复杂，而且某些参数的设置有严格的先后次序，否则可能会发生记录失败。如何封装记录器的初始化过程并保证多种记录器切换的灵活性是M公司开发人员面临的一个难题。
     */

    internal class Program
    {
        private static void Main(string[] args)
        {
            //此处可通过配置文件实现
            ILoggerFactory loggerFactory = new FileLoggerFactory();
            ILogger logger = loggerFactory.CreatLogger();
            if (logger != null)
            {
                logger.WriteLog();
            }

            //工厂方法的隐藏，简化客户端使用
            LoggerFactory_Simple factory = new DatabaseLoggerFactory_Simple();
            factory.WriteLog();

            Console.Read();
        }
    }
}