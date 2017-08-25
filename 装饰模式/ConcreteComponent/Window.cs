using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰模式
{
    /// <summary>
    /// 抽象构件的子类，用于定义具体的构件对象，实现了在抽象构件中声明的方法，装饰器可以给它增加额外的职责（方法）。
    /// </summary>
    public class Window : Component
    {
        public override void Display()
        {
            Console.WriteLine("显示窗体!");
        }
    }
}