using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰模式
{
    /// <summary>
    /// 抽象装饰类--构件装饰类
    /// 抽象构件类的子类，用于给具体构件增加职责，但是具体职责在其子类中实现。
    /// </summary>
    public class ComponentDecorator : Component
    {
        private Component component;

        public ComponentDecorator(Component component)
        {
            this.component = component;
        }

        public override void Display()
        {
            component.Display();
        }
    }
}