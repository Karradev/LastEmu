using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ObtainedItemMessage : NetworkMessage
	{
		public const uint Id = 6519;

		public uint genericId;

		public uint baseQuantity;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6519;
			}
		}

		public ObtainedItemMessage()
		{
		}

		public ObtainedItemMessage(uint genericId, uint baseQuantity)
		{
			this.genericId = genericId;
			this.baseQuantity = baseQuantity;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.genericId = reader.ReadVarUhShort();
			this.baseQuantity = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.genericId);
			writer.WriteVarInt((int)this.baseQuantity);
		}
	}
}