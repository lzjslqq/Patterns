using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1单例模式
{
	/// <summary>
	/// 懒汉式
	/// </summary>
	public class Singleton
	{
		private static readonly object obj = new object();
		private static Singleton instance = null;

		private Singleton()
		{
		}

		public static Singleton GetSingleton()
		{
			if (instance == null)
			{
				lock (obj)
				{
					if (instance == null)
					{
						instance = new Singleton();
					}
				}
			}
			return instance;
		}
	}
}