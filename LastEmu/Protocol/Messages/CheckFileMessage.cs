using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class CheckFileMessage : NetworkMessage
	{
		public const uint Id = 6156;

		public string filenameHash;

		public sbyte type;

		public string @value;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6156;
			}
		}

		public CheckFileMessage()
		{
		}

		public CheckFileMessage(string filenameHash, sbyte type, string value)
		{
			this.filenameHash = filenameHash;
			this.type = type;
			this.@value = value;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.filenameHash = reader.ReadUTF();
			this.type = reader.ReadSByte();
			this.@value = reader.ReadUTF();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(this.filenameHash);
			writer.WriteSByte(this.type);
			writer.WriteUTF(this.@value);
		}
	}
}