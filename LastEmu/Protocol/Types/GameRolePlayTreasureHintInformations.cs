using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class GameRolePlayTreasureHintInformations : GameRolePlayActorInformations
	{
		public const short Id = 471;

		public uint npcId;

		public override short TypeId
		{
			get
			{
				return 471;
			}
		}

		public GameRolePlayTreasureHintInformations()
		{
		}

		public GameRolePlayTreasureHintInformations(double contextualId, EntityLook look, EntityDispositionInformations disposition, uint npcId) : base(contextualId, look, disposition)
		{
			this.npcId = npcId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.npcId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((int)this.npcId);
		}
	}
}