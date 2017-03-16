using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class SellerBuyerDescriptor
	{
		public const short Id = 121;

		public uint[] quantities;

		public uint[] types;

		public double taxPercentage;

		public double taxModificationPercentage;

		public byte maxItemLevel;

		public uint maxItemPerAccount;

		public int npcContextualId;

		public uint unsoldDelay;

		public virtual short TypeId
		{
			get
			{
				return 121;
			}
		}

		public SellerBuyerDescriptor()
		{
		}

		public SellerBuyerDescriptor(uint[] quantities, uint[] types, double taxPercentage, double taxModificationPercentage, byte maxItemLevel, uint maxItemPerAccount, int npcContextualId, uint unsoldDelay)
		{
			this.quantities = quantities;
			this.types = types;
			this.taxPercentage = taxPercentage;
			this.taxModificationPercentage = taxModificationPercentage;
			this.maxItemLevel = maxItemLevel;
			this.maxItemPerAccount = maxItemPerAccount;
			this.npcContextualId = npcContextualId;
			this.unsoldDelay = unsoldDelay;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.quantities = new uint[num];
			for (int i = 0; i < num; i++)
			{
				this.quantities[i] = reader.ReadVarUhInt();
			}
			num = reader.ReadUShort();
			this.types = new uint[num];
			for (int j = 0; j < num; j++)
			{
				this.types[j] = reader.ReadVarUhInt();
			}
			this.taxPercentage = (double)reader.ReadFloat();
			this.taxModificationPercentage = (double)reader.ReadFloat();
			this.maxItemLevel = reader.ReadByte();
			this.maxItemPerAccount = reader.ReadVarUhInt();
			this.npcContextualId = reader.ReadInt();
			this.unsoldDelay = reader.ReadVarUhShort();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.quantities.Length));
			uint[] numArray = this.quantities;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteVarInt((int)numArray[i]);
			}
			writer.WriteShort((short)((int)this.types.Length));
			uint[] numArray1 = this.types;
			for (int j = 0; j < (int)numArray1.Length; j++)
			{
				writer.WriteVarInt((int)numArray1[j]);
			}
			writer.WriteFloat((float)this.taxPercentage);
			writer.WriteFloat((float)this.taxModificationPercentage);
			writer.WriteByte(this.maxItemLevel);
			writer.WriteVarInt((int)this.maxItemPerAccount);
			writer.WriteInt(this.npcContextualId);
			writer.WriteVarShort((int)this.unsoldDelay);
		}
	}
}