using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class AccountHouseInformations
	{
		public const short Id = 390;

		public uint houseId;

		public uint modelId;

		public short worldX;

		public short worldY;

		public int mapId;

		public uint subAreaId;

		public virtual short TypeId
		{
			get
			{
				return 390;
			}
		}

		public AccountHouseInformations()
		{
		}

		public AccountHouseInformations(uint houseId, uint modelId, short worldX, short worldY, int mapId, uint subAreaId)
		{
			this.houseId = houseId;
			this.modelId = modelId;
			this.worldX = worldX;
			this.worldY = worldY;
			this.mapId = mapId;
			this.subAreaId = subAreaId;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.houseId = reader.ReadVarUhInt();
			this.modelId = reader.ReadVarUhShort();
			this.worldX = reader.ReadShort();
			this.worldY = reader.ReadShort();
			this.mapId = reader.ReadInt();
			this.subAreaId = reader.ReadVarUhShort();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.houseId);
			writer.WriteVarShort((int)this.modelId);
			writer.WriteShort(this.worldX);
			writer.WriteShort(this.worldY);
			writer.WriteInt(this.mapId);
			writer.WriteVarShort((int)this.subAreaId);
		}
	}
}