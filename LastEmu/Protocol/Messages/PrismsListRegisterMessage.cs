using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class PrismsListRegisterMessage : NetworkMessage
	{
		public const uint Id = 6441;

		public sbyte listen;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6441;
			}
		}

		public PrismsListRegisterMessage()
		{
		}

		public PrismsListRegisterMessage(sbyte listen)
		{
			this.listen = listen;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.listen = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.listen);
		}
	}
}