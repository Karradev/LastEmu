using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class KrosmasterTransferMessage : NetworkMessage
	{
		public const uint Id = 6348;

		public string uid;

		public sbyte failure;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6348;
			}
		}

		public KrosmasterTransferMessage()
		{
		}

		public KrosmasterTransferMessage(string uid, sbyte failure)
		{
			this.uid = uid;
			this.failure = failure;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.uid = reader.ReadUTF();
			this.failure = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(this.uid);
			writer.WriteSByte(this.failure);
		}
	}
}