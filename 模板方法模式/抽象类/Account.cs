using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 模板方法模式
{
    /// <summary>
    /// 抽象类--账户类
    /// </summary>
    public abstract class Account
    {
        // 基本方法（验证账户信息） - 具体方法
        public bool Validate(string account, string password)
        {
            Console.WriteLine("账号 : {0}", account);
            Console.WriteLine("密码 : {0}", password);

            if (account.Equals("lqq") && password.Equals("123456"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // 基本方法（计算利息） - 抽象方法
        public abstract void CalculateInterest();

        // 基本方法（显示利息） - 具体方法
        public void Display()
        {
            Console.WriteLine("显示利息");
        }

        // 基本方法 - 钩子方法
        public virtual bool IsAllowDisplay()
        {
            return true;
        }

        // 模板方法
        public void Handle(string account, string password)
        {
            if (!Validate(account, password))
            {
                Console.WriteLine("账户或密码错误，请重新输入！");
                return;
            }

            CalculateInterest();

            if (IsAllowDisplay())
            {
                Display();
            }
        }
    }
}