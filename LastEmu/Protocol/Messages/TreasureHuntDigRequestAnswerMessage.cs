using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class TreasureHuntDigRequestAnswerMessage : NetworkMessage
	{
		public const uint Id = 6484;

		public sbyte questType;

		public sbyte result;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6484;
			}
		}

		public TreasureHuntDigRequestAnswerMessage()
		{
		}

		public TreasureHuntDigRequestAnswerMessage(sbyte questType, sbyte result)
		{
			this.questType = questType;
			this.result = result;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.questType = reader.ReadSByte();
			this.result = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.questType);
			writer.WriteSByte(this.result);
		}
	}
}