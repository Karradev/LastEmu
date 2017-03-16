using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class CheckFileRequestMessage : NetworkMessage
	{
		public const uint Id = 6154;

		public string filename;

		public sbyte type;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6154;
			}
		}

		public CheckFileRequestMessage()
		{
		}

		public CheckFileRequestMessage(string filename, sbyte type)
		{
			this.filename = filename;
			this.type = type;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.filename = reader.ReadUTF();
			this.type = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(this.filename);
			writer.WriteSByte(this.type);
		}
	}
}