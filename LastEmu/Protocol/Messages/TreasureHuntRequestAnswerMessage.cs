using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class TreasureHuntRequestAnswerMessage : NetworkMessage
	{
		public const uint Id = 6489;

		public sbyte questType;

		public sbyte result;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6489;
			}
		}

		public TreasureHuntRequestAnswerMessage()
		{
		}

		public TreasureHuntRequestAnswerMessage(sbyte questType, sbyte result)
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