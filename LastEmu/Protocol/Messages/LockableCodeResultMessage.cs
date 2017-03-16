using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class LockableCodeResultMessage : NetworkMessage
	{
		public const uint Id = 5672;

		public sbyte result;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5672;
			}
		}

		public LockableCodeResultMessage()
		{
		}

		public LockableCodeResultMessage(sbyte result)
		{
			this.result = result;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.result = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.result);
		}
	}
}