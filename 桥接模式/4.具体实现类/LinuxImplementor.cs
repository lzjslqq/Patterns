using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 桥接模式
{
    public class LinuxImplementor : ImageImplementor
    {
        public void DoPaint(Matrix m)
        {
            // 调用Linux的绘制函数绘制像素矩阵
            Console.WriteLine("在Linux系统中显示图像");
        }
    }
}