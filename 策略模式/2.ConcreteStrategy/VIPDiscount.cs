using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
	/// <summary>
	/// 具体策略类--VIP打折算法
	/// </summary>
	public class VIPDiscount : IDiscount
	{
		public double Calculate(double price)
		{
			Console.WriteLine("滴！VIP：");
			Console.WriteLine("增加了{0}积分！", price / 10);
			return price * 0.5;
		}
	}
}