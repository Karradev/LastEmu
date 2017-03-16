using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GuestLimitationMessage : NetworkMessage
	{
		public const uint Id = 6506;

		public sbyte reason;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6506;
			}
		}

		public GuestLimitationMessage()
		{
		}

		public GuestLimitationMessage(sbyte reason)
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