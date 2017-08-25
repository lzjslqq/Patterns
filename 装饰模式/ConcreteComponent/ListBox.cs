using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰模式
{
    public class ListBox : Component
    {
        public override void Display()
        {
            Console.WriteLine("显示列表框！");
        }
    }
}