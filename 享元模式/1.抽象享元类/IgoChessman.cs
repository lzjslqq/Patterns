using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 享元模式
{
    /// <summary>
    /// 一个接口或抽象类，声明了具体享元类的公共方法
    /// </summary>
    public abstract class IgoChessman
    {
        public abstract string GetColor();

        public void Display(Coordinates coordinates)
        {
            Console.WriteLine("棋子颜色：{0}，棋子位置：{1}", GetColor(), coordinates.X + "," + coordinates.Y);
        }
    }
}