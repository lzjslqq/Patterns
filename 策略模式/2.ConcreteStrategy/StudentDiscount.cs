using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
	/// <summary>
	/// 具体策略类--学生打折算法
	/// </summary>
	public class StudentDiscount : IDiscount
	{
		public double Calculate(double price)
		{
			Console.WriteLine("滴！学生卡：");
			return price * 0.8;
		}
	}
}