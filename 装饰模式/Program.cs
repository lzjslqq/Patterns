using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰模式
{
    /*
     *     M公司开发部基于OO技术开发了一套图形界面构件库Visual Component，该构件库提供了大量的基本构件，如窗体、文本框、列表框等等，由于在使用该构件库时，用户经常要求定制一些特殊的显示效果，例如带滚动条的窗体，带黑色边框的文本框，即带滚动条又带黑色边框的列表框等，因此经常需要对该构件库进行扩展以增强其功能.如何提高图形界面构件库的可扩展性并降低其维护成本是M公司开发部的程序猿们必须要面对的一个问题。
     */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Component component1 = new Window();

            //一次装饰
            Component component2 = new ScrollBarDecorator(component1);
            component2.Display();
            Console.WriteLine("________________________________");

            //二次装饰
            Component component3 = new BorderDecorator(component2);
            component3.Display();

            Console.ReadKey();
        }
    }
}