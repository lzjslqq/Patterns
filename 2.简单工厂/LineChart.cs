using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.简单工厂
{
	public class LineChart : IChart
	{
		public LineChart()
		{
			Console.WriteLine("创建折线图...");
		}

		public void Display()
		{
			Console.WriteLine("显示折线图...");
		}
	}
}