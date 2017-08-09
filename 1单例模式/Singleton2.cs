using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1单例模式
{
	/// <summary>
	/// 恶汉式
	/// </summary>
	public class Singleton2
	{
		private static Singleton2 instance = new Singleton2();

		private Singleton2()
		{
		}

		public static Singleton2 GetSingleton()
		{
			return instance;
		}
	}
}