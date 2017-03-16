using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class BasicGuildInformations : AbstractSocialGroupInfos
	{
		public const short Id = 365;

		public uint guildId;

		public string guildName;

		public byte guildLevel;

		public override short TypeId
		{
			get
			{
				return 365;
			}
		}

		public BasicGuildInformations()
		{
		}

		public BasicGuildInformations(uint guildId, string guildName, byte guildLevel)
		{
			this.guildId = guildId;
			this.guildName = guildName;
			this.guildLevel = guildLevel;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.guildId = reader.ReadVarUhInt();
			this.guildName = reader.ReadUTF();
			this.guildLevel = reader.ReadByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((int)this.guildId);
			writer.WriteUTF(this.guildName);
			writer.WriteByte(this.guildLevel);
		}
	}
}