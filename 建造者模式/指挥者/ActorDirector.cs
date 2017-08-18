using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 建造者模式
{
	public class ActorDirector
	{
		public Actor Construct(ActorBuilder builder)
		{
			builder.BuildType();
			builder.BuildSex();
			builder.BuildFace();
			builder.BuildCostume();
			builder.BuildHairStyle();

			return builder.CreateActor();
		}
	}
}