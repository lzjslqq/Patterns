using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者模式
{
    /*M公司欲开发一款多人联机对战游戏，在游戏中，多个游戏玩家可以加入同一战队组成联盟，当战队中某一成员收到敌人攻击时将给所有其他盟友发送通知，盟友收到通知后将作出响应。M公司开发人员需要提供一个设计方案来实现战队成员之间的联动。
     */

    internal class Program
    {
        private static void Main(string[] args)
        {
            // 被观察者
            AllyControlCenter acc = new ConcreteAllyControlCenter("Z战士");
            // 观察者
            IObserver play1 = new Player() { Name = "孙悟空" };
            acc.Join(play1);
            IObserver play2 = new Player() { Name = "贝吉塔" };
            acc.Join(play2);
            IObserver play3 = new Player() { Name = "孙悟饭" };
            acc.Join(play3);
            IObserver play4 = new Player() { Name = "天津饭" };
            acc.Join(play4);

            // 遭受攻击
            play1.BeAttacked(acc);

            Console.Read();
        }
    }
}