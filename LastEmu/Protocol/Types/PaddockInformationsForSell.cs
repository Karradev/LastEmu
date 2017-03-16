using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class PaddockInformationsForSell
	{
		public const short Id = 222;

		public string guildOwner;

		public short worldX;

		public short worldY;

		public uint subAreaId;

		public sbyte nbMount;

		public sbyte nbObject;

		public uint price;

		public virtual short TypeId
		{
			get
			{
				return 222;
			}
		}

		public PaddockInformationsForSell()
		{
		}

		public PaddockInformationsForSell(string guildOwner, short worldX, short worldY, uint subAreaId, sbyte nbMount, sbyte nbObject, uint price)
		{
			this.guildOwner = guildOwner;
			this.worldX = worldX;
			this.worldY = worldY;
			this.subAreaId = subAreaId;
			this.nbMount = nbMount;
			this.nbObject = nbObject;
			this.price = price;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.guildOwner = reader.ReadUTF();
			this.worldX = reader.ReadShort();
			this.worldY = reader.ReadShort();
			this.subAreaId = reader.ReadVarUhShort();
			this.nbMount = reader.ReadSByte();
			this.nbObject = reader.ReadSByte();
			this.price = reader.ReadVarUhInt();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(this.guildOwner);
			writer.WriteShort(this.worldX);
			writer.WriteShort(this.worldY);
			writer.WriteVarShort((int)this.subAreaId);
			writer.WriteSByte(this.nbMount);
			writer.WriteSByte(this.nbObject);
			writer.WriteVarInt((int)this.price);
		}
	}
}