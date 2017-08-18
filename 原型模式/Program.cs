using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 原型模式
{
    /*
     *     MM公司一直在使用自行开发的一个OA系统进行日常工作办理，但在使用过程中，越来越多的人对工作周报的创建和编写模块产生了抱怨。
     * 追其原因，M公司的OA管理员发现，由于某些岗位每周工作存在重复性，工作周报内容都大同小异。
     *     这些周报只有一些小地方存在差异，但是现行系统每周默认创建的周报都是空白报表，因此用户只能通过重新输入或不断地复制与粘贴来填写重复的周报内容，极大地降低了工作效率，浪费宝贵的时间。如何快速创建相同或者相似的工作周报，成为了M公司软件开发人员的一个新问题。
     *
     *     经过分析，决定按照以下思路对工作周报模块进行重新设计：

　　（1）除了允许用户创建新周报外，还允许用户将创建好的周报保存为模板（也就是原型）。

　　（2）用户在再次创建周报时，可以创建全新的周报，还可以选择合适的模板复制生成一个相同的周报，然后对新生成的周报根据实际情况进行修改，产生新的周报。
     */

    internal class Program
    {
        public static void PrintWeeklyLog(WeeklyLog log)
        {
            if (log == null)
            {
                return;
            }

            Console.WriteLine("----------- start : M公司个人工作周报 -----------");
            Console.WriteLine("周次：{0}", log.Date);
            Console.WriteLine("员工：{0}", log.Name);
            Console.WriteLine("内容：{0}", log.Content);
            Console.WriteLine("----------- end : M公司个人工作周报 -----------");
        }

        private static void Main(string[] args)
        {
            WeeklyLog log = new WeeklyLog();
            log.Name = "小明";
            log.Date = "第11周";
            log.Content = "这周很忙啊！";
            PrintWeeklyLog(log);

            WeeklyLog newLog = log.Clone() as WeeklyLog;
            newLog.Name = "小黄";
            newLog.Date = "第12周";
            //newLog.Content = "这周还好！";
            PrintWeeklyLog(newLog);

            Console.Read();
        }
    }
}