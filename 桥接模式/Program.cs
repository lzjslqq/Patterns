using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 桥接模式
{
    /*
     *     M公司开发部想要开发一个跨平台的图像浏览系统，要求该系统能够显示JPG、BMP、GIF、PNG等多种格式的文件，并且能够在Windows、Linux以及Unix等多个操作系统上运行。该系统首先将各种格式的文件解析为像素矩阵（Matrix），然后将像素矩阵显示在屏幕上，在不同的操作系统中可以调用不同的绘制函数来绘制像素矩阵。该系统需要具备较好的扩展性以支持新的文件格式和操作系统。
     *
     */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Image image = Utility.AppConfigHelper.CreateInstance("RefinedAbstraction") as Image;
            ImageImplementor imageImpl = Utility.AppConfigHelper.CreateInstance("ConcreteImplementor") as ImageImplementor;

            image.SetImageImplementor(imageImpl);
            image.ParstFile("小猫图片");

            Console.ReadKey();
        }
    }
}