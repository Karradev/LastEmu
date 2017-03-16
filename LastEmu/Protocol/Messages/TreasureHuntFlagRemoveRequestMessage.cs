using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class TreasureHuntFlagRemoveRequestMessage : NetworkMessage
	{
		public const uint Id = 6510;

		public sbyte questType;

		public sbyte index;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6510;
			}
		}

		public TreasureHuntFlagRemoveRequestMessage()
		{
		}

		public TreasureHuntFlagRemoveRequestMessage(sbyte questType, sbyte index)
		{
			this.questType = questType;
			this.index = index;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.questType = reader.ReadSByte();
			this.index = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.questType);
			writer.WriteSByte(this.index);
		}
	}
}