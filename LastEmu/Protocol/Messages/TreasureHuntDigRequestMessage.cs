using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class TreasureHuntDigRequestMessage : NetworkMessage
	{
		public const uint Id = 6485;

		public sbyte questType;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6485;
			}
		}

		public TreasureHuntDigRequestMessage()
		{
		}

		public TreasureHuntDigRequestMessage(sbyte questType)
		{
			this.questType = questType;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.questType = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.questType);
		}
	}
}