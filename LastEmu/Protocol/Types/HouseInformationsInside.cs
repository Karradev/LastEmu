using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class HouseInformationsInside
	{
		public const short Id = 218;

		public uint houseId;

		public uint modelId;

		public int ownerId;

		public string ownerName;

		public short worldX;

		public short worldY;

		public int price;

		public bool isLocked;

		public virtual short TypeId
		{
			get
			{
				return 218;
			}
		}

		public HouseInformationsInside()
		{
		}

		public HouseInformationsInside(uint houseId, uint modelId, int ownerId, string ownerName, short worldX, short worldY, int price, bool isLocked)
		{
			this.houseId = houseId;
			this.modelId = modelId;
			this.ownerId = ownerId;
			this.ownerName = ownerName;
			this.worldX = worldX;
			this.worldY = worldY;
			this.price = price;
			this.isLocked = isLocked;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.houseId = reader.ReadVarUhInt();
			this.modelId = reader.ReadVarUhShort();
			this.ownerId = reader.ReadInt();
			this.ownerName = reader.ReadUTF();
			this.worldX = reader.ReadShort();
			this.worldY = reader.ReadShort();
			this.price = reader.ReadInt();
			this.isLocked = reader.ReadBoolean();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.houseId);
			writer.WriteVarShort((int)this.modelId);
			writer.WriteInt(this.ownerId);
			writer.WriteUTF(this.ownerName);
			writer.WriteShort(this.worldX);
			writer.WriteShort(this.worldY);
			writer.WriteInt(this.price);
			writer.WriteBoolean(this.isLocked);
		}
	}
}