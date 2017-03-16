using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class RawDataMessage : NetworkMessage
	{
		public const uint Id = 6253;

		public byte[] Content;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6253;
			}
		}

		public RawDataMessage()
		{
		}

		public RawDataMessage(byte[] content)
		{
			this.Content = content;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.Content = reader.ReadBytes(reader.ReadVarInt());
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.Content.Length);
			writer.WriteBytes(this.Content);
		}
	}
}