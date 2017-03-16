using Protocol.IO;

using System;

namespace Protocol.Types
{
	public class HouseInformations
	{
		public const short Id = 111;

		public bool isOnSale;

		public bool isSaleLocked;

		public uint houseId;

		public int[] doorsOnMap;

		public string ownerName;

		public uint modelId;

		public virtual short TypeId
		{
			get
			{
				return 111;
			}
		}

		public HouseInformations()
		{
		}

		public HouseInformations(bool isOnSale, bool isSaleLocked, uint houseId, int[] doorsOnMap, string ownerName, uint modelId)
		{
			this.isOnSale = isOnSale;
			this.isSaleLocked = isSaleLocked;
			this.houseId = houseId;
			this.doorsOnMap = doorsOnMap;
			this.ownerName = ownerName;
			this.modelId = modelId;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			byte num = reader.ReadByte();
			this.isOnSale = BooleanByteWrapper.GetFlag(num, 0);
			this.isSaleLocked = BooleanByteWrapper.GetFlag(num, 1);
			this.houseId = reader.ReadVarUhInt();
			ushort num1 = reader.ReadUShort();
			this.doorsOnMap = new int[num1];
			for (int i = 0; i < num1; i++)
			{
				this.doorsOnMap[i] = reader.ReadInt();
			}
			this.ownerName = reader.ReadUTF();
			this.modelId = reader.ReadVarUhShort();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			byte num = BooleanByteWrapper.SetFlag(0, 0, this.isOnSale);
			writer.WriteByte(BooleanByteWrapper.SetFlag(num, 1, this.isSaleLocked));
			writer.WriteVarInt((int)this.houseId);
			writer.WriteShort((short)((int)this.doorsOnMap.Length));
			int[] numArray = this.doorsOnMap;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteInt(numArray[i]);
			}
			writer.WriteUTF(this.ownerName);
			writer.WriteVarShort((int)this.modelId);
		}
	}
}