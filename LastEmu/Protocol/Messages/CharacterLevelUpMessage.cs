using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class CharacterLevelUpMessage : NetworkMessage
	{
		public const uint Id = 5670;

		public byte newLevel;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5670;
			}
		}

		public CharacterLevelUpMessage()
		{
		}

		public CharacterLevelUpMessage(byte newLevel)
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