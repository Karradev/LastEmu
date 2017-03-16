using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeCrafterJobLevelupMessage : NetworkMessage
	{
		public const uint Id = 6598;

		public byte crafterJobLevel;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6598;
			}
		}

		public ExchangeCrafterJobLevelupMessage()
		{
		}

		public ExchangeCrafterJobLevelupMessage(byte crafterJobLevel)
		{
			this.crafterJobLevel = crafterJobLevel;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.crafterJobLevel = reader.ReadByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteByte(this.crafterJobLevel);
		}
	}
}