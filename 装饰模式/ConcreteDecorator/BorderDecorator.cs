using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰模式
{
    public class BorderDecorator : ComponentDecorator
    {
        public BorderDecorator(Component component)
            : base(component)
        {
        }

        public override void Display()
        {
            base.Display();
            this.SetBorder();
        }

        public void SetBorder()
        {
            Console.WriteLine("为构件增加边框！");
        }
    }
}