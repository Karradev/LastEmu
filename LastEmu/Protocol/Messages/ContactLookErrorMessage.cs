using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ContactLookErrorMessage : NetworkMessage
	{
		public const uint Id = 6045;

		public uint requestId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6045;
			}
		}

		public ContactLookErrorMessage()
		{
		}

		public ContactLookErrorMessage(uint requestId)
		{
			this.requestId = requestId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.requestId = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.requestId);
		}
	}
}