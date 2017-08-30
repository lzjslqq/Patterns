using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 代理模式
{
    /// <summary>
    /// 业务类：日志记录类
    /// </summary>
    public class Logger
    {
        /// <summary>
        /// 模拟实现日志记录
        /// </summary>
        /// <param name="userId"></param>
        public void Log(string userId)
        {
            Console.WriteLine("更新数据库，用户 {0} 查询次数 +1 !", userId);
        }
    }
}