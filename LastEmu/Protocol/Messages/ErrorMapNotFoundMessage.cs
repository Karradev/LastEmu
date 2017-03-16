using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ErrorMapNotFoundMessage : NetworkMessage
	{
		public const uint Id = 6197;

		public int mapId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6197;
			}
		}

		public ErrorMapNotFoundMessage()
		{
		}

		public ErrorMapNotFoundMessage(int mapId)
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