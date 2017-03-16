using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class GameRolePlayNpcWithQuestInformations : GameRolePlayNpcInformations
	{
		public const short Id = 383;

		public GameRolePlayNpcQuestFlag questFlag;

		public override short TypeId
		{
			get
			{
				return 383;
			}
		}

		public GameRolePlayNpcWithQuestInformations()
		{
		}

		public GameRolePlayNpcWithQuestInformations(double contextualId, EntityLook look, EntityDispositionInformations disposition, uint npcId, bool sex, uint specialArtworkId, GameRolePlayNpcQuestFlag questFlag) : base(contextualId, look, disposition, npcId, sex, specialArtworkId)
		{
			this.questFlag = questFlag;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.questFlag = new GameRolePlayNpcQuestFlag();
			this.questFlag.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			this.questFlag.Serialize(writer);
		}
	}
}