using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class PaddockBuyRequestMessage : NetworkMessage
	{
		public const uint Id = 5951;

		public uint proposedPrice;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5951;
			}
		}

		public PaddockBuyRequestMessage()
		{
		}

		public PaddockBuyRequestMessage(uint proposedPrice)
		{
			this.proposedPrice = proposedPrice;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.proposedPrice = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.proposedPrice);
		}
	}
}