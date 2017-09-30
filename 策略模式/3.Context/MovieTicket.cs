using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
	/// <summary>
	/// 上下文类--电影票
	/// </summary>
	public class MovieTicket
	{
		private double _price;
		private IDiscount _discount;

		public MovieTicket()
		{
		}

		public MovieTicket(double price)
		{
			this._price = price;
		}

		public double Price
		{
			get { return _discount.Calculate(_price); }
			set { _price = value; }
		}

		public IDiscount Discount
		{
			set
			{
				_discount = value;
			}
		}
	}
}