using Protocol.IO;

using System;

namespace Protocol.Types
{
	public class JobCrafterDirectoryEntryPlayerInfo
	{
		public const short Id = 194;

		public double playerId;

		public string playerName;

		public sbyte alignmentSide;

		public sbyte breed;

		public bool sex;

		public bool isInWorkshop;

		public short worldX;

		public short worldY;

		public int mapId;

		public uint subAreaId;

		public PlayerStatus status;

		public virtual short TypeId
		{
			get
			{
				return 194;
			}
		}

		public JobCrafterDirectoryEntryPlayerInfo()
		{
		}

		public JobCrafterDirectoryEntryPlayerInfo(double playerId, string playerName, sbyte alignmentSide, sbyte breed, bool sex, bool isInWorkshop, short worldX, short worldY, int mapId, uint subAreaId, PlayerStatus status)
		{
			this.playerId = playerId;
			this.playerName = playerName;
			this.alignmentSide = alignmentSide;
			this.breed = breed;
			this.sex = sex;
			this.isInWorkshop = isInWorkshop;
			this.worldX = worldX;
			this.worldY = worldY;
			this.mapId = mapId;
			this.subAreaId = subAreaId;
			this.status = status;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.playerId = reader.ReadVarUhLong();
			this.playerName = reader.ReadUTF();
			this.alignmentSide = reader.ReadSByte();
			this.breed = reader.ReadSByte();
			this.sex = reader.ReadBoolean();
			this.isInWorkshop = reader.ReadBoolean();
			this.worldX = reader.ReadShort();
			this.worldY = reader.ReadShort();
			this.mapId = reader.ReadInt();
			this.subAreaId = reader.ReadVarUhShort();
			this.status = ProtocolTypeManager.GetInstance<PlayerStatus>(reader.ReadUShort());
			this.status.Deserialize(reader);
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(this.playerId);
			writer.WriteUTF(this.playerName);
			writer.WriteSByte(this.alignmentSide);
			writer.WriteSByte(this.breed);
			writer.WriteBoolean(this.sex);
			writer.WriteBoolean(this.isInWorkshop);
			writer.WriteShort(this.worldX);
			writer.WriteShort(this.worldY);
			writer.WriteInt(this.mapId);
			writer.WriteVarShort((int)this.subAreaId);
			writer.WriteShort(this.status.TypeId);
			this.status.Serialize(writer);
		}
	}
}