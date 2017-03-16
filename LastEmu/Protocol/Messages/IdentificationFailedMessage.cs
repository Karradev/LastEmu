using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class IdentificationFailedMessage : NetworkMessage
	{
		public const uint Id = 20;

		public sbyte reason;

		public override uint ProtocolId
		{
			get
			{
				return (uint)20;
			}
		}

		public IdentificationFailedMessage()
		{
		}

		public IdentificationFailedMessage(sbyte reason)
		{
			this.reason = reason;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.reason = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.reason);
		}
	}
}