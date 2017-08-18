using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 建造者模式
{
	/// <summary>
	/// 天使角色建造器 ：具体建造者
	/// </summary>
	public class AngelBuilder : ActorBuilder
	{
		public override void BuildType()
		{
			actor.Type = "天使";
		}

		public override void BuildCostume()
		{
			actor.Costume = "白裙";
		}

		public override void BuildFace()
		{
			actor.Face = "漂亮脸蛋";
		}

		public override void BuildSex()
		{
			actor.Sex = "女";
		}

		public override void BuildHairStyle()
		{
			actor.HairStyle = "披肩长发";
		}
	}
}