using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class MountDataErrorMessage : NetworkMessage
	{
		public const uint Id = 6172;

		public sbyte reason;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6172;
			}
		}

		public MountDataErrorMessage()
		{
		}

		public MountDataErrorMessage(sbyte reason)
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