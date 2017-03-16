using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class CurrentMapMessage : NetworkMessage
	{
		public const uint Id = 220;

		public int mapId;

		public string mapKey;

		public override uint ProtocolId
		{
			get
			{
				return (uint)220;
			}
		}

		public CurrentMapMessage()
		{
		}

		public CurrentMapMessage(int mapId, string mapKey)
		{
			this.mapId = mapId;
			this.mapKey = mapKey;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.mapId = reader.ReadInt();
			this.mapKey = reader.ReadUTF();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.mapId);
			writer.WriteUTF(this.mapKey);
		}
	}
}