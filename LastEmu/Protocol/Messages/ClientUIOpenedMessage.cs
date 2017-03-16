using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ClientUIOpenedMessage : NetworkMessage
	{
		public const uint Id = 6459;

		public sbyte type;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6459;
			}
		}

		public ClientUIOpenedMessage()
		{
		}

		public ClientUIOpenedMessage(sbyte type)
		{
			this.type = type;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.type = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.type);
		}
	}
}