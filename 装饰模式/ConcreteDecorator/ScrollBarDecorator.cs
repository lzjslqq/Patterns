using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰模式
{
    /// <summary>
    /// 滚动条装饰类
    /// 抽象装饰类的子类，负责向构件添加新的职责。
    /// </summary>
    public class ScrollBarDecorator : ComponentDecorator
    {
        public ScrollBarDecorator(Component component)
            : base(component)
        {
        }

        public override void Display()
        {
            base.Display();
            this.SetScrollBar();
        }

        public void SetScrollBar()
        {
            Console.WriteLine("为构件增加滚动条！");
        }
    }
}