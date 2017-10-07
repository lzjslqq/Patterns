using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 命令模式
{
    /// <summary>
    /// 抽象命令类
    /// </summary>
    public abstract class Command
    {
        /// <summary>
        /// 命令执行方法
        /// </summary>
        public abstract void Execute();
    }
}