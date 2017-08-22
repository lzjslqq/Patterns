using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 桥接模式
{
    public class BMPImage : Image
    {
        public override void ParstFile(string fileName)
        {
            // 模拟解析BMP文件并获得一个像素矩阵对象m
            Matrix m = new Matrix();
            imageImpl.DoPaint(m);
            Console.WriteLine("{0} : 格式为BMP", fileName);
        }
    }
}