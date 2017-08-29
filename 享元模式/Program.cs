using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 享元模式
{
    /*    M公司开发人员通过对围棋软件进行分析，发现在围棋棋盘中包含大量的黑子和白子，它们的形状、大小都一模一样，只是出现的位置不同而已。如果将每一个棋子都作为一个独立的对象存储在内存中，将可能导致该围棋软件在运行时所需要的内存空间较大。
　　  如何降低运行代价、提高系统性能是M公司开发人员需要解决的一个问题。为此，M公司开发人员决定使用享元模式来设计该软件。
     */

    internal class Program
    {
        /// <summary>
        ///   享元（Flyweight）模式：运用共享技术有效地支持大量细粒度对象的复用。系统只使用少量的对象，而这些对象都很相似，状态变化很小，可以实现对象的多次复用。由于享元模式要求能够共享的对象必须是细粒度对象，因此它又称为轻量级模式，是一种结构型模式。
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            // 获取享元工厂
            IgoChessmanFactory chessFactory = IgoChessmanFactory.GetInstance();
            // 通过享元工厂获取3颗黑子
            IgoChessman black1 = chessFactory.GetIgoChessman("black");
            IgoChessman black2 = chessFactory.GetIgoChessman("black");
            IgoChessman black3 = chessFactory.GetIgoChessman("black");

            Console.WriteLine("判断两颗黑子是否相同：{0}", object.ReferenceEquals(black1, black2));

            // 通过享元工厂获取2颗白子
            IgoChessman white1 = chessFactory.GetIgoChessman("white");
            IgoChessman white2 = chessFactory.GetIgoChessman("white");

            Console.WriteLine("判断两颗白子是否相同：{0}", object.ReferenceEquals(white1, white2));
            Console.WriteLine("判断黑子，白子是否相同：{0}", object.ReferenceEquals(black1, white2));

            // 显示棋子
            black1.Display(new Coordinates(1, 3));
            black1.Display(new Coordinates(2, 4));
            black1.Display(new Coordinates(5, 7));
            white1.Display(new Coordinates(15, 25));
            white2.Display(new Coordinates(18, 30));

            Console.ReadKey();
        }
    }
}