using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 访问者模式
{
    /// <summary>
    /// 具体元素类：全职员工
    /// </summary>
    public class FullTimeEmployee : IEmployee
    {
        public string Name { get; set; }
        public double WeeklyWage { get; set; }
        public int WorkTime { get; set; }

        public FullTimeEmployee(string name, double weeklyWage, int workTime)
        {
            this.Name = name;
            this.WeeklyWage = weeklyWage;
            this.WorkTime = workTime;
        }

        public void Accept(Department handler)
        {
            handler.Visit(this);
        }
    }
}