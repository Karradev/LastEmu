using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeMountsTakenFromPaddockMessage : NetworkMessage
	{
		public const uint Id = 6554;

		public string name;

		public short worldX;

		public short worldY;

		public string ownername;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6554;
			}
		}

		public ExchangeMountsTakenFromPaddockMessage()
		{
		}

		public ExchangeMountsTakenFromPaddockMessage(string name, short worldX, short worldY, string ownername)
		{
			this.name = name;
			this.worldX = worldX;
			this.worldY = worldY;
			this.ownername = ownername;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.name = reader.ReadUTF();
			this.worldX = reader.ReadShort();
			this.worldY = reader.ReadShort();
			this.ownername = reader.ReadUTF();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(this.name);
			writer.WriteShort(this.worldX);
			writer.WriteShort(this.worldY);
			writer.WriteUTF(this.ownername);
		}
	}
}