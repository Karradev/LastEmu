using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class TreasureHuntFlagRequestAnswerMessage : NetworkMessage
	{
		public const uint Id = 6507;

		public sbyte questType;

		public sbyte result;

		public sbyte index;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6507;
			}
		}

		public TreasureHuntFlagRequestAnswerMessage()
		{
		}

		public TreasureHuntFlagRequestAnswerMessage(sbyte questType, sbyte result, sbyte index)
		{
			this.questType = questType;
			this.result = result;
			this.index = index;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.questType = reader.ReadSByte();
			this.result = reader.ReadSByte();
			this.index = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.questType);
			writer.WriteSByte(this.result);
			writer.WriteSByte(this.index);
		}
	}
}