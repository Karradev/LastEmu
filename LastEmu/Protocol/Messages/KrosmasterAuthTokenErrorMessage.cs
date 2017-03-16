using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class KrosmasterAuthTokenErrorMessage : NetworkMessage
	{
		public const uint Id = 6345;

		public sbyte reason;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6345;
			}
		}

		public KrosmasterAuthTokenErrorMessage()
		{
		}

		public KrosmasterAuthTokenErrorMessage(sbyte reason)
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