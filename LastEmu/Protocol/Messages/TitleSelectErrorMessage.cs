using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class TitleSelectErrorMessage : NetworkMessage
	{
		public const uint Id = 6373;

		public sbyte reason;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6373;
			}
		}

		public TitleSelectErrorMessage()
		{
		}

		public TitleSelectErrorMessage(sbyte reason)
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