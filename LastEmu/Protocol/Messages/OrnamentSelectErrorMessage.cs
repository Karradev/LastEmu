using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class OrnamentSelectErrorMessage : NetworkMessage
	{
		public const uint Id = 6370;

		public sbyte reason;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6370;
			}
		}

		public OrnamentSelectErrorMessage()
		{
		}

		public OrnamentSelectErrorMessage(sbyte reason)
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