using Protocol.IO;

using System;

namespace Protocol.Types
{
	public class PrismGeolocalizedInformation : PrismSubareaEmptyInfo
	{
		public const short Id = 434;

		public short worldX;

		public short worldY;

		public int mapId;

		public PrismInformation prism;

		public override short TypeId
		{
			get
			{
				return 434;
			}
		}

		public PrismGeolocalizedInformation()
		{
		}

		public PrismGeolocalizedInformation(uint subAreaId, uint allianceId, short worldX, short worldY, int mapId, PrismInformation prism) : base(subAreaId, allianceId)
		{
			this.worldX = worldX;
			this.worldY = worldY;
			this.mapId = mapId;
			this.prism = prism;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.worldX = reader.ReadShort();
			this.worldY = reader.ReadShort();
			this.mapId = reader.ReadInt();
			this.prism = ProtocolTypeManager.GetInstance<PrismInformation>(reader.ReadUShort());
			this.prism.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort(this.worldX);
			writer.WriteShort(this.worldY);
			writer.WriteInt(this.mapId);
			writer.WriteShort(this.prism.TypeId);
			this.prism.Serialize(writer);
		}
	}
}