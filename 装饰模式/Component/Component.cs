using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰模式
{
    /// <summary>
    /// （抽象构件）：具体构件和抽象装饰类的基类，声明了在具体构建中实现的业务方法。
    /// </summary>
    public abstract class Component
    {
        public abstract void Display();
    }
}