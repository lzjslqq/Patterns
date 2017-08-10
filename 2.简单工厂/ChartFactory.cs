using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.简单工厂
{
	public class ChartFactory
	{
		public static IChart GetChart(string type)
		{
			type = type.ToLower();
			IChart chart = null;
			switch (type)
			{
				case "histogram":
					chart = new HistogramChart();
					Console.WriteLine("设置为柱状图...");
					break;

				case "line":
					chart = new LineChart();
					Console.WriteLine("设置为折线图...");
					break;

				case "pie":
					chart = new PieChart();
					Console.WriteLine("设置为饼图...");
					break;

				default:
					chart = new HistogramChart();
					Console.WriteLine("设置为柱状图...");
					break;
			}

			return chart;
		}
	}
}