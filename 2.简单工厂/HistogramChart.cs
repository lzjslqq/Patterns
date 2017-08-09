﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.简单工厂
{
	public class HistogramChart : IChart
	{
		public HistogramChart()
		{
			Console.WriteLine("创建柱状图...");
		}

		public void Display()
		{
			Console.WriteLine("显示柱状图...");
		}
	}
}