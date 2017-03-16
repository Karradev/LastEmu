using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class PrismInfoInValidMessage : NetworkMessage
	{
		public const uint Id = 5859;

		public sbyte reason;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5859;
			}
		}

		public PrismInfoInValidMessage()
		{
		}

		public PrismInfoInValidMessage(sbyte reason)
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