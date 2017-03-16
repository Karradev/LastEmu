using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class TaxCollectorBasicInformations
	{
		public const short Id = 96;

		public uint firstNameId;

		public uint lastNameId;

		public short worldX;

		public short worldY;

		public int mapId;

		public uint subAreaId;

		public virtual short TypeId
		{
			get
			{
				return 96;
			}
		}

		public TaxCollectorBasicInformations()
		{
		}

		public TaxCollectorBasicInformations(uint firstNameId, uint lastNameId, short worldX, short worldY, int mapId, uint subAreaId)
		{
			this.firstNameId = firstNameId;
			this.lastNameId = lastNameId;
			this.worldX = worldX;
			this.worldY = worldY;
			this.mapId = mapId;
			this.subAreaId = subAreaId;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.firstNameId = reader.ReadVarUhShort();
			this.lastNameId = reader.ReadVarUhShort();
			this.worldX = reader.ReadShort();
			this.worldY = reader.ReadShort();
			this.mapId = reader.ReadInt();
			this.subAreaId = reader.ReadVarUhShort();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.firstNameId);
			writer.WriteVarShort((int)this.lastNameId);
			writer.WriteShort(this.worldX);
			writer.WriteShort(this.worldY);
			writer.WriteInt(this.mapId);
			writer.WriteVarShort((int)this.subAreaId);
		}
	}
}