using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class HouseInformationsForGuild
	{
		public const short Id = 170;

		public uint houseId;

		public uint modelId;

		public string ownerName;

		public short worldX;

		public short worldY;

		public int mapId;

		public uint subAreaId;

		public int[] skillListIds;

		public uint guildshareParams;

		public virtual short TypeId
		{
			get
			{
				return 170;
			}
		}

		public HouseInformationsForGuild()
		{
		}

		public HouseInformationsForGuild(uint houseId, uint modelId, string ownerName, short worldX, short worldY, int mapId, uint subAreaId, int[] skillListIds, uint guildshareParams)
		{
			this.houseId = houseId;
			this.modelId = modelId;
			this.ownerName = ownerName;
			this.worldX = worldX;
			this.worldY = worldY;
			this.mapId = mapId;
			this.subAreaId = subAreaId;
			this.skillListIds = skillListIds;
			this.guildshareParams = guildshareParams;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.houseId = reader.ReadVarUhInt();
			this.modelId = reader.ReadVarUhInt();
			this.ownerName = reader.ReadUTF();
			this.worldX = reader.ReadShort();
			this.worldY = reader.ReadShort();
			this.mapId = reader.ReadInt();
			this.subAreaId = reader.ReadVarUhShort();
			ushort num = reader.ReadUShort();
			this.skillListIds = new int[num];
			for (int i = 0; i < num; i++)
			{
				this.skillListIds[i] = reader.ReadInt();
			}
			this.guildshareParams = reader.ReadVarUhInt();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.houseId);
			writer.WriteVarInt((int)this.modelId);
			writer.WriteUTF(this.ownerName);
			writer.WriteShort(this.worldX);
			writer.WriteShort(this.worldY);
			writer.WriteInt(this.mapId);
			writer.WriteVarShort((int)this.subAreaId);
			writer.WriteShort((short)((int)this.skillListIds.Length));
			int[] numArray = this.skillListIds;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteInt(numArray[i]);
			}
			writer.WriteVarInt((int)this.guildshareParams);
		}
	}
}