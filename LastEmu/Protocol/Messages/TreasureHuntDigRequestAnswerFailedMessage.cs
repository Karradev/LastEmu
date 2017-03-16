using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class TreasureHuntDigRequestAnswerFailedMessage : TreasureHuntDigRequestAnswerMessage
	{
		public const uint Id = 6509;

		public sbyte wrongFlagCount;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6509;
			}
		}

		public TreasureHuntDigRequestAnswerFailedMessage()
		{
		}

		public TreasureHuntDigRequestAnswerFailedMessage(sbyte questType, sbyte result, sbyte wrongFlagCount) : base(questType, result)
		{
			this.wrongFlagCount = wrongFlagCount;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.wrongFlagCount = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteSByte(this.wrongFlagCount);
		}
	}
}