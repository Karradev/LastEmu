using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GuildLevelUpMessage : NetworkMessage
	{
		public const uint Id = 6062;

		public byte newLevel;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6062;
			}
		}

		public GuildLevelUpMessage()
		{
		}

		public GuildLevelUpMessage(byte newLevel)
		{
			this.newLevel = newLevel;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.newLevel = reader.ReadByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteByte(this.newLevel);
		}
	}
}