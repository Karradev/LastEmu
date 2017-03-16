using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class ZaapListMessage : TeleportDestinationsListMessage
	{
		public const uint Id = 1604;

		public int spawnMapId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)1604;
			}
		}

		public ZaapListMessage()
		{
		}

		public ZaapListMessage(sbyte teleporterType, int[] mapIds, uint[] subAreaIds, uint[] costs, sbyte[] destTeleporterType, int spawnMapId) : base(teleporterType, mapIds, subAreaIds, costs, destTeleporterType)
		{
			this.spawnMapId = spawnMapId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.spawnMapId = reader.ReadInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt(this.spawnMapId);
		}
	}
}