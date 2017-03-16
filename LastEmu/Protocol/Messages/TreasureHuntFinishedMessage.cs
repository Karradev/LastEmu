using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class TreasureHuntFinishedMessage : NetworkMessage
	{
		public const uint Id = 6483;

		public sbyte questType;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6483;
			}
		}

		public TreasureHuntFinishedMessage()
		{
		}

		public TreasureHuntFinishedMessage(sbyte questType)
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