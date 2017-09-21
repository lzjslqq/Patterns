using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者模式
{
    /// <summary>
    /// 抽象观察者
    /// </summary>
    public interface IObserver
    {
        string Name { get; set; }

        // 声明支援盟友的方法
        void Help();

        // 声明遭受攻击的方法
        void BeAttacked(AllyControlCenter acc);
    }
}