using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 访问者模式
{
    /// <summary>
    /// 具体元素类:兼职员工
    /// </summary>
    public class PartTimeEmployee : IEmployee
    {
        public string Name { get; set; }
        public double HourWage { get; set; }
        public int WorkTime { get; set; }

        public PartTimeEmployee(string name, double hourWage, int workTime)
        {
            this.Name = name;
            this.HourWage = hourWage;
            this.WorkTime = workTime;
        }

        public void Accept(Department handler)
        {
            handler.Visit(this);
        }
    }
}