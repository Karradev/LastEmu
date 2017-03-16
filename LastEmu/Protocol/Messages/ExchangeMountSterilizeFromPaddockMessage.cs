using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeMountSterilizeFromPaddockMessage : NetworkMessage
	{
		public const uint Id = 6056;

		public string name;

		public short worldX;

		public short worldY;

		public string sterilizator;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6056;
			}
		}

		public ExchangeMountSterilizeFromPaddockMessage()
		{
		}

		public ExchangeMountSterilizeFromPaddockMessage(string name, short worldX, short worldY, string sterilizator)
		{
			this.name = name;
			this.worldX = worldX;
			this.worldY = worldY;
			this.sterilizator = sterilizator;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.name = reader.ReadUTF();
			this.worldX = reader.ReadShort();
			this.worldY = reader.ReadShort();
			this.sterilizator = reader.ReadUTF();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(this.name);
			writer.WriteShort(this.worldX);
			writer.WriteShort(this.worldY);
			writer.WriteUTF(this.sterilizator);
		}
	}
}