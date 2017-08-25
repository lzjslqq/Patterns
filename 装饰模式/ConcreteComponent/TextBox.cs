using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰模式
{
    /// <summary>
    /// 具体构件类--文本框类
    /// </summary>
    public class TextBox : Component
    {
        public override void Display()
        {
            Console.WriteLine("显示文本框！");
        }
    }
}