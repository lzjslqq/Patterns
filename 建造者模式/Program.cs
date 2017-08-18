using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace 建造者模式
{
	/*建造者模式（Builder）：将一个复杂对象的构建与它的表示相分离，使得同样的构建过程可以创建不同的表示*/

	/*
	 * M公司游戏开发部想要开发一款网络游戏，该游戏采用主流的RPG（角色扮演游戏）模式，玩家可以在游戏中扮演各种特定的角色，而各个角色又可以根据不同的游戏情节和统计数据（如力量、魔法、技能等）具有不同的能力，角色也会随着不断升级而拥有更加强大的能力。

       作为RPG游戏的一个重要组成部分，需要对游戏角色进行设计，而且随着该游戏的升级将不断增加新的角色。不同类型的游戏角色，其性别、脸型、服装、发型等外部特性都有所差异，例如“天使”拥有美丽的面容和披肩的长发，并身穿一袭白裙；而“恶魔”则极其丑陋，留着光头并穿着一件刺眼的黑衣。

       M公司决定开发一个小工具来创建游戏角色，可以创建不同类型的角色并可以灵活地增加新角色
	 */

	internal class Program
	{
		private static void Main(string[] args)
		{
			ActorBuilder builder = AppConfigHelper.CreateInstance("ConcreteBuilder") as ActorBuilder;
			ActorDirector director = new ActorDirector();
			Actor actor = director.Construct(builder);

			Console.WriteLine("角色类型：{0}", actor.Type);
			Console.WriteLine("角色性别：{0}", actor.Sex);
			Console.WriteLine("角色面容：{0}", actor.Face);
			Console.WriteLine("角色服装：{0}", actor.Costume);
			Console.WriteLine("角色发型：{0}", actor.HairStyle);

			Console.ReadKey();
		}
	}
}