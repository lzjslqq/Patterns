using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
	/// <summary>
	/// M公司为某电影院开发了一套影院售票系统，在该系统中需要为不同类型的用户提供不同的电影票打折方式，具体打折方案如下：
	///（1）学生凭学生证可享受票价8折优惠；
	///（2）年龄在10周岁以及以下的儿童可以享受每张票减免10元的优惠（原始票价需要大于20元）；
	///（3）影院VIP用户除享受票价八折优惠外还可以进行积分，积分累计到一定额度可以换取电影院赠送的奖品；
	/// 该系统在将来还可能会根据需求引入更多的打折方案。　
	/// </summary>
	internal class Program
	{
		/// <summary>
		/// 策略（Strategy）模式：定义一系列算法类，将每一个算法封装起来，并让它们可以相互替换。
		/// 策略模式让算法独立于使用它的客户而变化。它也被成为政策模式，是一种行为型模式。
		/// </summary>
		/// <param name="args"></param>
		private static void Main(string[] args)
		{
			double originalPrice = 60.0;
			double currentPrice = originalPrice;
			MovieTicket ticket = new MovieTicket(originalPrice);

			Console.WriteLine("原始票价：{0}", originalPrice);
			Console.WriteLine("----------------------------------------");

			var discount = Utility.AppConfigHelper.CreateInstance("DiscountStrategy") as IDiscount;
			if (discount != null)
			{
				ticket.Discount = discount;
				Console.WriteLine("折后票价：{0}", ticket.Price);
			}

			Console.Read();
		}
	}
}