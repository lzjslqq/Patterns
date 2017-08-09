using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1单例模式
{
	/// <summary>
	/// Singleton
	/// </summary>
	internal class Program
	{
		private static void Main(string[] args)
		{
			Singleton3 single1 = Singleton3.GetSingleton();
			Singleton3 single2 = Singleton3.GetSingleton();

			bool isEqual = single1.Equals(single2);

			Console.WriteLine(isEqual);
			Console.ReadKey();
		}
	}
}