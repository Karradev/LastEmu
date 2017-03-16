using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class HouseInformationsForSell
	{
		public const short Id = 221;

		public uint modelId;

		public string ownerName;

		public bool ownerConnected;

		public short worldX;

		public short worldY;

		public uint subAreaId;

		public sbyte nbRoom;

		public sbyte nbChest;

		public int[] skillListIds;

		public bool isLocked;

		public uint price;

		public virtual short TypeId
		{
			get
			{
				return 221;
			}
		}

		public HouseInformationsForSell()
		{
		}

		public HouseInformationsForSell(uint modelId, string ownerName, bool ownerConnected, short worldX, short worldY, uint subAreaId, sbyte nbRoom, sbyte nbChest, int[] skillListIds, bool isLocked, uint price)
		{
			this.modelId = modelId;
			this.ownerName = ownerName;
			this.ownerConnected = ownerConnected;
			this.worldX = worldX;
			this.worldY = worldY;
			this.subAreaId = subAreaId;
			this.nbRoom = nbRoom;
			this.nbChest = nbChest;
			this.skillListIds = skillListIds;
			this.isLocked = isLocked;
			this.price = price;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.modelId = reader.ReadVarUhInt();
			this.ownerName = reader.ReadUTF();
			this.ownerConnected = reader.ReadBoolean();
			this.worldX = reader.ReadShort();
			this.worldY = reader.ReadShort();
			this.subAreaId = reader.ReadVarUhShort();
			this.nbRoom = reader.ReadSByte();
			this.nbChest = reader.ReadSByte();
			ushort num = reader.ReadUShort();
			this.skillListIds = new int[num];
			for (int i = 0; i < num; i++)
			{
				this.skillListIds[i] = reader.ReadInt();
			}
			this.isLocked = reader.ReadBoolean();
			this.price = reader.ReadVarUhInt();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.modelId);
			writer.WriteUTF(this.ownerName);
			writer.WriteBoolean(this.ownerConnected);
			writer.WriteShort(this.worldX);
			writer.WriteShort(this.worldY);
			writer.WriteVarShort((int)this.subAreaId);
			writer.WriteSByte(this.nbRoom);
			writer.WriteSByte(this.nbChest);
			writer.WriteShort((short)((int)this.skillListIds.Length));
			int[] numArray = this.skillListIds;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteInt(numArray[i]);
			}
			writer.WriteBoolean(this.isLocked);
			writer.WriteVarInt((int)this.price);
		}
	}
}