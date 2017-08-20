using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace 适配器模式
{
    /// <summary>
    ///    某公司以前有一套算法库，里面包含了一些常用的算法，例如排序和查找算法。现在在开发一个学校的教务管理系统时，开发了一个成绩操作接口 IScoreOperation,里面声明了排序和查找方法。为了提高排序和查找的效率，开发人员决定重用算法库中的快速排序算法类QuickSort和二分查找算法类BinarySearch。但是，由于某些原因，现在M公司开发人员已经找不到该算法库的源代码，无法直接通过复制合粘贴操作来重用其中的代码；部分开发人员已经针对IScoreOperation接口编写代码，如果这时再要求对该接口修改或者要求大家直接使用QuickSort类和BinarySearch类将会导致大量代码需要修改。
    ///    因此，M公司开发人员面对这个没有源码的算法库，遇到了一个问题：如何在既不修改现有接口又不需要任何算法库代码的基础上实现算法库的重用？　
    ///
    /// 适配器（Adapter）模式：将一个接口转换成客户希望的另一个接口，使接口不兼容的那些类可以一起工作。
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            IScoreOperation operation = AppConfigHelper.CreateInstance("AdapterName") as IScoreOperation;
            if (operation == null)
            {
                return;
            }

            int[] scores = { 84, 76, 50, 69, 90, 91, 88, 96 };
            int[] result;
            int score;

            Console.WriteLine("测试成绩排序结果：");
            result = operation.Sort(scores);
            foreach (int s in result)
            {
                Console.Write("{0},", s.ToString());
            }
            Console.WriteLine();

            Console.WriteLine("查找是否有90分的人：");
            score = operation.Search(scores, 90);
            if (score == -1)
            {
                Console.WriteLine("抱歉，这个真没找到~~~");
            }
            else
            {
                Console.WriteLine("恭喜，的确存在90分选手~~~");
            }

            Console.WriteLine("查找是否有92分的人：");
            score = operation.Search(scores, 92);
            if (score == -1)
            {
                Console.WriteLine("抱歉，这个真没找到~~~");
            }
            else
            {
                Console.WriteLine("恭喜，的确存在92分选手~~~");
            }

            Console.ReadKey();
        }
    }
}