using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class PartyMemberGeoPosition
	{
		public const short Id = 378;

		public int memberId;

		public short worldX;

		public short worldY;

		public int mapId;

		public uint subAreaId;

		public virtual short TypeId
		{
			get
			{
				return 378;
			}
		}

		public PartyMemberGeoPosition()
		{
		}

		public PartyMemberGeoPosition(int memberId, short worldX, short worldY, int mapId, uint subAreaId)
		{
			this.memberId = memberId;
			this.worldX = worldX;
			this.worldY = worldY;
			this.mapId = mapId;
			this.subAreaId = subAreaId;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.memberId = reader.ReadInt();
			this.worldX = reader.ReadShort();
			this.worldY = reader.ReadShort();
			this.mapId = reader.ReadInt();
			this.subAreaId = reader.ReadVarUhShort();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.memberId);
			writer.WriteShort(this.worldX);
			writer.WriteShort(this.worldY);
			writer.WriteInt(this.mapId);
			writer.WriteVarShort((int)this.subAreaId);
		}
	}
}