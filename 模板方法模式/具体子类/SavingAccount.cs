using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 模板方法模式
{
    /// <summary>
    /// 具体子类--定期账户
    /// </summary>
    public class SavingAccount : Account
    {
        // 重写父类的抽象基本方法(计算利息算法)
        public override void CalculateInterest()
        {
            Console.WriteLine("按定期利率计算利息！");
        }

        // 重写父类的钩子方法
        public override bool IsAllowDisplay()
        {
            return false;
        }
    }
}