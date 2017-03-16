using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class HouseBuyRequestMessage : NetworkMessage
	{
		public const uint Id = 5738;

		public uint proposedPrice;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5738;
			}
		}

		public HouseBuyRequestMessage()
		{
		}

		public HouseBuyRequestMessage(uint proposedPrice)
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