using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 命令模式
{
    /// <summary>
    /// 具体命令类：帮助命令
    /// </summary>
    public class HelpCommand : Command
    {
        private HelpHandler handler;

        public HelpCommand()
        {
            handler = new HelpHandler();
        }

        // 命令执行方法，将调用请求接受者的业务方法
        public override void Execute()
        {
            if (handler != null)
            {
                handler.Display();
            }
        }
    }
}