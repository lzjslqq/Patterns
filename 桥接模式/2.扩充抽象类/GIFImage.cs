using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 桥接模式
{
    public class GIFImage : Image
    {
        public override void ParstFile(string fileName)
        {
            // 模拟解析GIF文件并获得一个像素矩阵对象m
            Matrix m = new Matrix();
            imageImpl.DoPaint(m);
            Console.WriteLine("{0} : 格式为GIF", fileName);
        }
    }
}