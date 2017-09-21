using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者模式
{
    /// <summary>
    /// 抽象目标类--战队控制中心
    /// </summary>
    public abstract class AllyControlCenter
    {
        public string AllyName { get; set; }
        protected IList<IObserver> playerList = new List<IObserver>();

        public void Join(IObserver observer)
        {
            playerList.Add(observer);
            Console.WriteLine("通知：【{0}】加入了【{1}】战队！", observer.Name, this.AllyName);
        }

        public void Quit(IObserver observer)
        {
            playerList.Remove(observer);
            Console.WriteLine("通知：【{0}】退出了【{1}】战队！", observer.Name, this.AllyName);
        }

        /// <summary>
        /// 通知观察者的方法
        /// </summary>
        /// <param name="name"></param>
        public abstract void NotifyObserver(string name);
    }
}