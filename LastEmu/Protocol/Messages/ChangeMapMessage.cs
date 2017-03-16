using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ChangeMapMessage : NetworkMessage
	{
		public const uint Id = 221;

		public int mapId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)221;
			}
		}

		public ChangeMapMessage()
		{
		}

		public ChangeMapMessage(int mapId)
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