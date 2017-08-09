using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1单例模式
{
	/// <summary>
	/// 该实现方法在内部定义了一个私有类型Nested。当第一次用到这个嵌套类型的时候，会调用静态构造函数创建Singleton3的实例instance。如果不调用属性
	/// Singleton3.Instance，那么就不会触发.NET运行时（CLR）调用Nested，也就不会创建实例，因此也就保证了按需创建实例（或延迟初始化）。
	/// 可见，此方法既可以实现延迟加载，又可以保证线程安全，不影响系统性能。
	/// </summary>
	public class Singleton3
	{
		private Singleton3()
		{
		}

		// 公共静态成员方法，返回唯一实例
		public static Singleton3 GetSingleton()
		{
			return Nested.instance;
		}

		// 使用内部类+静态构造函数实现延迟初始化
		private class Nested
		{
			static Nested()
			{
			}

			internal static readonly Singleton3 instance = new Singleton3();
		}
	}
}