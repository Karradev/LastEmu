using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ObjectFoundWhileRecoltingMessage : NetworkMessage
	{
		public const uint Id = 6017;

		public uint genericId;

		public uint quantity;

		public uint resourceGenericId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6017;
			}
		}

		public ObjectFoundWhileRecoltingMessage()
		{
		}

		public ObjectFoundWhileRecoltingMessage(uint genericId, uint quantity, uint resourceGenericId)
		{
			this.genericId = genericId;
			this.quantity = quantity;
			this.resourceGenericId = resourceGenericId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.genericId = reader.ReadVarUhShort();
			this.quantity = reader.ReadVarUhInt();
			this.resourceGenericId = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.genericId);
			writer.WriteVarInt((int)this.quantity);
			writer.WriteVarInt((int)this.resourceGenericId);
		}
	}
}