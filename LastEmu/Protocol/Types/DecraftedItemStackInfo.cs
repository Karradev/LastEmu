using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class DecraftedItemStackInfo
	{
		public const short Id = 481;

		public uint objectUID;

		public double bonusMin;

		public double bonusMax;

		public uint[] runesId;

		public uint[] runesQty;

		public virtual short TypeId
		{
			get
			{
				return 481;
			}
		}

		public DecraftedItemStackInfo()
		{
		}

		public DecraftedItemStackInfo(uint objectUID, double bonusMin, double bonusMax, uint[] runesId, uint[] runesQty)
		{
			this.objectUID = objectUID;
			this.bonusMin = bonusMin;
			this.bonusMax = bonusMax;
			this.runesId = runesId;
			this.runesQty = runesQty;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.objectUID = reader.ReadVarUhInt();
			this.bonusMin = (double)reader.ReadFloat();
			this.bonusMax = (double)reader.ReadFloat();
			ushort num = reader.ReadUShort();
			this.runesId = new uint[num];
			for (int i = 0; i < num; i++)
			{
				this.runesId[i] = reader.ReadVarUhShort();
			}
			num = reader.ReadUShort();
			this.runesQty = new uint[num];
			for (int j = 0; j < num; j++)
			{
				this.runesQty[j] = reader.ReadVarUhInt();
			}
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.objectUID);
			writer.WriteFloat((float)this.bonusMin);
			writer.WriteFloat((float)this.bonusMax);
			writer.WriteShort((short)((int)this.runesId.Length));
			uint[] numArray = this.runesId;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteVarShort((int)numArray[i]);
			}
			writer.WriteShort((short)((int)this.runesQty.Length));
			uint[] numArray1 = this.runesQty;
			for (int j = 0; j < (int)numArray1.Length; j++)
			{
				writer.WriteVarInt((int)numArray1[j]);
			}
		}
	}
}