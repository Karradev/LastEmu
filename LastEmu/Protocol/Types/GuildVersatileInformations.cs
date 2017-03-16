using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class GuildVersatileInformations
	{
		public const short Id = 435;

		public uint guildId;

		public double leaderId;

		public byte guildLevel;

		public byte nbMembers;

		public virtual short TypeId
		{
			get
			{
				return 435;
			}
		}

		public GuildVersatileInformations()
		{
		}

		public GuildVersatileInformations(uint guildId, double leaderId, byte guildLevel, byte nbMembers)
		{
			this.guildId = guildId;
			this.leaderId = leaderId;
			this.guildLevel = guildLevel;
			this.nbMembers = nbMembers;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.guildId = reader.ReadVarUhInt();
			this.leaderId = reader.ReadVarUhLong();
			this.guildLevel = reader.ReadByte();
			this.nbMembers = reader.ReadByte();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.guildId);
			writer.WriteVarLong(this.leaderId);
			writer.WriteByte(this.guildLevel);
			writer.WriteByte(this.nbMembers);
		}
	}
}