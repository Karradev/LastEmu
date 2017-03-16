using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class TeleportRequestMessage : NetworkMessage
	{
		public const uint Id = 5961;

		public sbyte teleporterType;

		public int mapId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5961;
			}
		}

		public TeleportRequestMessage()
		{
		}

		public TeleportRequestMessage(sbyte teleporterType, int mapId)
		{
			this.teleporterType = teleporterType;
			this.mapId = mapId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.teleporterType = reader.ReadSByte();
			this.mapId = reader.ReadInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.teleporterType);
			writer.WriteInt(this.mapId);
		}
	}
}