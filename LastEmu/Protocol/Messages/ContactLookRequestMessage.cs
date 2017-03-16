using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ContactLookRequestMessage : NetworkMessage
	{
		public const uint Id = 5932;

		public byte requestId;

		public sbyte contactType;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5932;
			}
		}

		public ContactLookRequestMessage()
		{
		}

		public ContactLookRequestMessage(byte requestId, sbyte contactType)
		{
			this.requestId = requestId;
			this.contactType = contactType;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.requestId = reader.ReadByte();
			this.contactType = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteByte(this.requestId);
			writer.WriteSByte(this.contactType);
		}
	}
}