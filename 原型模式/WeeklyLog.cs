using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 原型模式
{
    /// <summary>
    /// 具体原型类--工作周报
    /// 只列出部分与原型模式相关的核心代码
    /// </summary>
    public class WeeklyLog : ICloneable
    {
        public string Name { get; set; }

        public string Date { get; set; }
        public string Content { get; set; }

        public object Clone()
        {
            WeeklyLog obj = new WeeklyLog();
            obj.Name = this.Name;
            obj.Date = this.Date;
            obj.Content = this.Content;

            return obj;
        }
    }
}