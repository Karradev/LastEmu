using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class HaapiApiKeyRequestMessage : NetworkMessage
	{
		public const uint Id = 6648;

		public sbyte keyType;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6648;
			}
		}

		public HaapiApiKeyRequestMessage()
		{
		}

		public HaapiApiKeyRequestMessage(sbyte keyType)
		{
			this.keyType = keyType;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.keyType = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.keyType);
		}
	}
}