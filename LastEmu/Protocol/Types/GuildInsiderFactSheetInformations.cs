using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class GuildInsiderFactSheetInformations : GuildFactSheetInformations
	{
		public const short Id = 423;

		public string leaderName;

		public uint nbConnectedMembers;

		public sbyte nbTaxCollectors;

		public int lastActivity;

		public override short TypeId
		{
			get
			{
				return 423;
			}
		}

		public GuildInsiderFactSheetInformations()
		{
		}

		public GuildInsiderFactSheetInformations(uint guildId, string guildName, byte guildLevel, GuildEmblem guildEmblem, double leaderId, uint nbMembers, string leaderName, uint nbConnectedMembers, sbyte nbTaxCollectors, int lastActivity) : base(guildId, guildName, guildLevel, guildEmblem, leaderId, nbMembers)
		{
			this.leaderName = leaderName;
			this.nbConnectedMembers = nbConnectedMembers;
			this.nbTaxCollectors = nbTaxCollectors;
			this.lastActivity = lastActivity;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.leaderName = reader.ReadUTF();
			this.nbConnectedMembers = reader.ReadVarUhShort();
			this.nbTaxCollectors = reader.ReadSByte();
			this.lastActivity = reader.ReadInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteUTF(this.leaderName);
			writer.WriteVarShort((int)this.nbConnectedMembers);
			writer.WriteSByte(this.nbTaxCollectors);
			writer.WriteInt(this.lastActivity);
		}
	}
}