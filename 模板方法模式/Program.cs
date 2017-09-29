using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 模板方法模式
{
    /// <summary>
    /// M公司欲为某银行的业务支撑系统开发一个利息计算模块，利息计算流程如下：
    ///（1）系统根据账号和密码验证用户信息，如果用户信息错误，系统显示错误提示。
    ///（2）如果用户信息正确，则根据用户类型的不同使用不同的利息计算公式计算利息（例如活期账户和定期账户具有不同的利息计算公式）
    ///（3）系统显示利息。
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// 模板方法模式：定义一个操作中算法的框架，而将一些步骤延迟到子类中，模板方法使得子类可以不改变一个算法的结构即可重新定义该算法的特定步骤
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            Account acount = Utility.AppConfigHelper.CreateInstance("AccountType") as Account;
            if (acount != null)
                acount.Handle("lqq", "123456");

            Console.Read();
        }
    }
}