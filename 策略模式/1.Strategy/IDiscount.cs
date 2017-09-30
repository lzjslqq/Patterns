using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
	/// <summary>
	/// 抽象策略类--折扣算法
	/// </summary>
	public interface IDiscount
	{
		double Calculate(double price);
	}
}