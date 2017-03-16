using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class GuildInAllianceVersatileInformations : GuildVersatileInformations
	{
		public const short Id = 437;

		public uint allianceId;

		public override short TypeId
		{
			get
			{
				return 437;
			}
		}

		public GuildInAllianceVersatileInformations()
		{
		}

		public GuildInAllianceVersatileInformations(uint guildId, double leaderId, byte guildLevel, byte nbMembers, uint allianceId) : base(guildId, leaderId, guildLevel, nbMembers)
		{
			this.allianceId = allianceId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.allianceId = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((int)this.allianceId);
		}
	}
}