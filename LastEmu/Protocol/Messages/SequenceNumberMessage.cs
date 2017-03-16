using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class SequenceNumberMessage : NetworkMessage
	{
		public const uint Id = 6317;

		public ushort number;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6317;
			}
		}

		public SequenceNumberMessage()
		{
		}

		public SequenceNumberMessage(ushort number)
		{
			this.number = number;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.number = reader.ReadUShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUShort(this.number);
		}
	}
}