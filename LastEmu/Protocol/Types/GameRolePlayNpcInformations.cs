using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class GameRolePlayNpcInformations : GameRolePlayActorInformations
	{
		public const short Id = 156;

		public uint npcId;

		public bool sex;

		public uint specialArtworkId;

		public override short TypeId
		{
			get
			{
				return 156;
			}
		}

		public GameRolePlayNpcInformations()
		{
		}

		public GameRolePlayNpcInformations(double contextualId, EntityLook look, EntityDispositionInformations disposition, uint npcId, bool sex, uint specialArtworkId) : base(contextualId, look, disposition)
		{
			this.npcId = npcId;
			this.sex = sex;
			this.specialArtworkId = specialArtworkId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.npcId = reader.ReadVarUhShort();
			this.sex = reader.ReadBoolean();
			this.specialArtworkId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((int)this.npcId);
			writer.WriteBoolean(this.sex);
			writer.WriteVarShort((int)this.specialArtworkId);
		}
	}
}