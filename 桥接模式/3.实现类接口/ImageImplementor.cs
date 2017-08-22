using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 桥接模式
{
    /// <summary>
    /// 实现类接口——抽象操作系统类
    /// </summary>
    public interface ImageImplementor
    {
        // 显示像素矩阵
        void DoPaint(Matrix m);
    }
}