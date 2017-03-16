using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeMountFreeFromPaddockMessage : NetworkMessage
	{
		public const uint Id = 6055;

		public string name;

		public short worldX;

		public short worldY;

		public string liberator;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6055;
			}
		}

		public ExchangeMountFreeFromPaddockMessage()
		{
		}

		public ExchangeMountFreeFromPaddockMessage(string name, short worldX, short worldY, string liberator)
		{
			this.name = name;
			this.worldX = worldX;
			this.worldY = worldY;
			this.liberator = liberator;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.name = reader.ReadUTF();
			this.worldX = reader.ReadShort();
			this.worldY = reader.ReadShort();
			this.liberator = reader.ReadUTF();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(this.name);
			writer.WriteShort(this.worldX);
			writer.WriteShort(this.worldY);
			writer.WriteUTF(this.liberator);
		}
	}
}