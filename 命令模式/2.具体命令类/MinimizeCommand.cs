using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 命令模式
{
    /// <summary>
    /// 具体命令类：最小化命令
    /// </summary>
    public class MinimizeCommand : Command
    {
        private WindowHandler handler;

        public MinimizeCommand()
        {
            handler = new WindowHandler();
        }

        public override void Execute()
        {
            if (handler != null)
            {
                handler.Minimize();
            }
        }
    }
}