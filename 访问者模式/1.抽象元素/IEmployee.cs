using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 访问者模式
{
    /// <summary>
    /// 抽象元素类
    /// </summary>
    public interface IEmployee
    {
        void Accept(Department handler);
    }
}