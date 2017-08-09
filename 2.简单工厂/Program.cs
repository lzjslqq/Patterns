using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.简单工厂
{
	/// <summary>
	/// M公司想要基于C#语言开发一套图表库，该图表库可以为应用系统提供各种不同外观的图标，例如柱状图、饼状图或折线图等。
	/// M公司图表库设计开发人员希望为应用系统开发人员提供一套灵活易用的图表库，而且可以较为方便地对图表库进行扩展，以便于在将来增加一些新类型的图表。
	/// </summary>
	internal class Program
	{
		private static void Main(string[] args)
		{
			//客户端使用时可以改为从配置文件读取参数
			IChart chart1 = ChartFactory.GetChart("line");
			if (chart1 != null)
			{
				chart1.Display();
			}

			IChart chart2 = ChartFactory.GetChart("pie");
			if (chart2 != null)
			{
				chart2.Display();
			}

			Console.ReadKey();
		}
	}
}