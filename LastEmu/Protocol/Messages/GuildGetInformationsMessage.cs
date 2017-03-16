using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GuildGetInformationsMessage : NetworkMessage
	{
		public const uint Id = 5550;

		public sbyte infoType;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5550;
			}
		}

		public GuildGetInformationsMessage()
		{
		}

		public GuildGetInformationsMessage(sbyte infoType)
		{
			this.infoType = infoType;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.infoType = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.infoType);
		}
	}
}