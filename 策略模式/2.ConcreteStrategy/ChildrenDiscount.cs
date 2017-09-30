using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
	/// <summary>
	/// 具体策略类--儿童打折算法
	/// </summary>
	public class ChildrenDiscount : IDiscount
	{
		public double Calculate(double price)
		{
			Console.WriteLine("滴！儿童卡：");
			if (price > 20)
				price -= 10;
			return price;
		}
	}
}