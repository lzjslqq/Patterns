using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 访问者模式
{
    /// <summary>
    /// 具体访问者：财务部门
    /// </summary>
    public class FinanceDepartment : Department
    {
        /// <summary>
        ///  实现财务部对全职员工数据的访问
        /// </summary>
        /// <param name="employee"></param>
        public override void Visit(FullTimeEmployee employee)
        {
            int workTime = employee.WorkTime;
            double weekWage = employee.WeeklyWage;

            if (workTime > 40)
            {
                weekWage = weekWage + (workTime - 40) * 50;
            }
            else if (workTime < 40)
            {
                weekWage = weekWage - (40 - workTime) * 80;
                if (weekWage < 0)
                {
                    weekWage = 0;
                }
            }

            Console.WriteLine("正式员工 {0} 实际工资为：{1} 元", employee.Name, weekWage);
        }

        /// <summary>
        /// 实现财务部对兼职员工数据的访问
        /// </summary>
        /// <param name="employee"></param>
        public override void Visit(PartTimeEmployee employee)
        {
            int workTime = employee.WorkTime;
            double hourWage = employee.HourWage;
            Console.WriteLine("临时工 {0} 实际工资为：{1} 元", employee.Name, workTime * hourWage);
        }
    }
}