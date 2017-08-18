﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 建造者模式
{
	/// <summary>
	/// 英雄建造器 ： 具体建造者
	/// </summary>
	public class HeroBuilder : ActorBuilder
	{
		public override void BuildCostume()
		{
			actor.Costume = "盔甲";
		}

		public override void BuildFace()
		{
			actor.Face = "英俊";
		}

		public override void BuildHairStyle()
		{
			actor.HairStyle = "大背头";
		}

		public override void BuildSex()
		{
			actor.Sex = "男";
		}

		public override void BuildType()
		{
			actor.Type = "英雄";
		}
	}
}