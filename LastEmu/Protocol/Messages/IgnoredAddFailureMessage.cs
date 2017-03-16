using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class IgnoredAddFailureMessage : NetworkMessage
	{
		public const uint Id = 5679;

		public sbyte reason;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5679;
			}
		}

		public IgnoredAddFailureMessage()
		{
		}

		public IgnoredAddFailureMessage(sbyte reason)
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