using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 迭代器模式
{
    internal class Program
    {
        /// <summary>
        /// 提供一种方法来访问聚合对象，而不用暴露这个对象的内部表示，别名为游标（Cursor）。是一种对象行为型模式。
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            IList<object> products = new List<object>();
            products.Add("测试产品1");
            products.Add("测试产品2");
            products.Add("测试产品3");
            products.Add("测试产品4");
            products.Add("测试产品5");
            products.Add("测试产品6");
            products.Add("测试产品7");

            // 创建聚合对象
            AbstractObjectList objectList = new ProductList(products);
            // 创建迭代器对象
            AbstractIterator iterator = objectList.CreateIterator();

            Console.WriteLine("正向遍历开始");
            while (!iterator.IsLast())
            {
                Console.WriteLine(iterator.GetNextItem());
                iterator.MoveNext();
            }

            Console.WriteLine("正向遍历结束");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("逆向遍历开始");
            while (!iterator.IsFirst())
            {
                Console.WriteLine(iterator.GetPreviousItem());
                iterator.MovePrevious();
            }

            Console.WriteLine("逆向遍历结束");
            Console.ReadKey();
        }
    }
}