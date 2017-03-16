using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class GameRolePlayCharacterInformations : GameRolePlayHumanoidInformations
	{
		public const short Id = 36;

		public ActorAlignmentInformations alignmentInfos;

		public override short TypeId
		{
			get
			{
				return 36;
			}
		}

		public GameRolePlayCharacterInformations()
		{
		}

		public GameRolePlayCharacterInformations(double contextualId, EntityLook look, EntityDispositionInformations disposition, string name, HumanInformations humanoidInfo, int accountId, ActorAlignmentInformations alignmentInfos) : base(contextualId, look, disposition, name, humanoidInfo, accountId)
		{
			this.alignmentInfos = alignmentInfos;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.alignmentInfos = new ActorAlignmentInformations();
			this.alignmentInfos.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			this.alignmentInfos.Serialize(writer);
		}
	}
}