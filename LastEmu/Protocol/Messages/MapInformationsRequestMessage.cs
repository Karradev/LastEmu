using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class MapInformationsRequestMessage : NetworkMessage
	{
		public const uint Id = 225;

		public int mapId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)225;
			}
		}

		public MapInformationsRequestMessage()
		{
		}

		public MapInformationsRequestMessage(int mapId)
		{
			this.mapId = mapId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.mapId = reader.ReadInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.mapId);
		}
	}
}