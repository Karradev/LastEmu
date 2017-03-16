using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class AcquaintanceSearchErrorMessage : NetworkMessage
	{
		public const uint Id = 6143;

		public sbyte reason;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6143;
			}
		}

		public AcquaintanceSearchErrorMessage()
		{
		}

		public AcquaintanceSearchErrorMessage(sbyte reason)
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