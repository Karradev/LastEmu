using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ObjectErrorMessage : NetworkMessage
	{
		public const uint Id = 3004;

		public sbyte reason;

		public override uint ProtocolId
		{
			get
			{
				return (uint)3004;
			}
		}

		public ObjectErrorMessage()
		{
		}

		public ObjectErrorMessage(sbyte reason)
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