using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class TreasureHuntGiveUpRequestMessage : NetworkMessage
	{
		public const uint Id = 6487;

		public sbyte questType;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6487;
			}
		}

		public TreasureHuntGiveUpRequestMessage()
		{
		}

		public TreasureHuntGiveUpRequestMessage(sbyte questType)
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