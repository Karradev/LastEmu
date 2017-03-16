using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class HaapiApiKeyMessage : NetworkMessage
	{
		public const uint Id = 6649;

		public sbyte keyType;

		public string token;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6649;
			}
		}

		public HaapiApiKeyMessage()
		{
		}

		public HaapiApiKeyMessage(sbyte keyType, string token)
		{
			this.keyType = keyType;
			this.token = token;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.keyType = reader.ReadSByte();
			this.token = reader.ReadUTF();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.keyType);
			writer.WriteUTF(this.token);
		}
	}
}