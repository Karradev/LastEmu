using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class GuildFactSheetInformations : GuildInformations
	{
		public const short Id = 424;

		public double leaderId;

		public uint nbMembers;

		public override short TypeId
		{
			get
			{
				return 424;
			}
		}

		public GuildFactSheetInformations()
		{
		}

		public GuildFactSheetInformations(uint guildId, string guildName, byte guildLevel, GuildEmblem guildEmblem, double leaderId, uint nbMembers) : base(guildId, guildName, guildLevel, guildEmblem)
		{
			this.leaderId = leaderId;
			this.nbMembers = nbMembers;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.leaderId = reader.ReadVarUhLong();
			this.nbMembers = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarLong(this.leaderId);
			writer.WriteVarShort((int)this.nbMembers);
		}
	}
}