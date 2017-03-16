using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class KrosmasterTransferRequestMessage : NetworkMessage
	{
		public const uint Id = 6349;

		public string uid;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6349;
			}
		}

		public KrosmasterTransferRequestMessage()
		{
		}

		public KrosmasterTransferRequestMessage(string uid)
		{
			this.uid = uid;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.uid = reader.ReadUTF();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(this.uid);
		}
	}
}