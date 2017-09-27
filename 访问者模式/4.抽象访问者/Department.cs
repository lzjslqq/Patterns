using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 访问者模式
{
    /// <summary>
    /// 抽象访问者
    /// </summary>
    public abstract class Department
    {
        // 声明一组重载的访问方法，用于访问不同类型的具体元素
        public abstract void Visit(FullTimeEmployee employee);

        public abstract void Visit(PartTimeEmployee employee);
    }
}