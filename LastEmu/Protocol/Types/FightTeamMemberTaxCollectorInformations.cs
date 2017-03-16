using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class FightTeamMemberTaxCollectorInformations : FightTeamMemberInformations
	{
		public const short Id = 177;

		public uint firstNameId;

		public uint lastNameId;

		public byte level;

		public uint guildId;

		public uint uid;

		public override short TypeId
		{
			get
			{
				return 177;
			}
		}

		public FightTeamMemberTaxCollectorInformations()
		{
		}

		public FightTeamMemberTaxCollectorInformations(double id, uint firstNameId, uint lastNameId, byte level, uint guildId, uint uid) : base(id)
		{
			this.firstNameId = firstNameId;
			this.lastNameId = lastNameId;
			this.level = level;
			this.guildId = guildId;
			this.uid = uid;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.firstNameId = reader.ReadVarUhShort();
			this.lastNameId = reader.ReadVarUhShort();
			this.level = reader.ReadByte();
			this.guildId = reader.ReadVarUhInt();
			this.uid = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((int)this.firstNameId);
			writer.WriteVarShort((int)this.lastNameId);
			writer.WriteByte(this.level);
			writer.WriteVarInt((int)this.guildId);
			writer.WriteVarInt((int)this.uid);
		}
	}
}