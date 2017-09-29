using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 模板方法模式
{
    /// <summary>
    /// 具体类--活期账户
    /// </summary>
    public class CurrentAccount : Account
    {
        // 重写父类的抽象基本方法(计算利息算法)
        public override void CalculateInterest()
        {
            Console.WriteLine("按活期利率计算利息！");
        }

        // 重写父类的钩子方法
        public override bool IsAllowDisplay()
        {
            return base.IsAllowDisplay();
        }
    }
}