using Protocol.IO;

using System;

namespace Protocol.Types
{
	public class PartyMemberInformations : CharacterBaseInformations
	{
		public const short Id = 90;

		public uint lifePoints;

		public uint maxLifePoints;

		public uint prospecting;

		public byte regenRate;

		public uint initiative;

		public sbyte alignmentSide;

		public short worldX;

		public short worldY;

		public int mapId;

		public uint subAreaId;

		public PlayerStatus status;

		public PartyCompanionMemberInformations[] companions;

		public override short TypeId
		{
			get
			{
				return 90;
			}
		}

		public PartyMemberInformations()
		{
		}

		public PartyMemberInformations(double id, string name, byte level, EntityLook entityLook, sbyte breed, bool sex, uint lifePoints, uint maxLifePoints, uint prospecting, byte regenRate, uint initiative, sbyte alignmentSide, short worldX, short worldY, int mapId, uint subAreaId, PlayerStatus status, PartyCompanionMemberInformations[] companions) : base(id, name, level, entityLook, breed, sex)
		{
			this.lifePoints = lifePoints;
			this.maxLifePoints = maxLifePoints;
			this.prospecting = prospecting;
			this.regenRate = regenRate;
			this.initiative = initiative;
			this.alignmentSide = alignmentSide;
			this.worldX = worldX;
			this.worldY = worldY;
			this.mapId = mapId;
			this.subAreaId = subAreaId;
			this.status = status;
			this.companions = companions;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.lifePoints = reader.ReadVarUhInt();
			this.maxLifePoints = reader.ReadVarUhInt();
			this.prospecting = reader.ReadVarUhShort();
			this.regenRate = reader.ReadByte();
			this.initiative = reader.ReadVarUhShort();
			this.alignmentSide = reader.ReadSByte();
			this.worldX = reader.ReadShort();
			this.worldY = reader.ReadShort();
			this.mapId = reader.ReadInt();
			this.subAreaId = reader.ReadVarUhShort();
			this.status = ProtocolTypeManager.GetInstance<PlayerStatus>(reader.ReadUShort());
			this.status.Deserialize(reader);
			ushort num = reader.ReadUShort();
			this.companions = new PartyCompanionMemberInformations[num];
			for (int i = 0; i < num; i++)
			{
				this.companions[i] = new PartyCompanionMemberInformations();
				this.companions[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((int)this.lifePoints);
			writer.WriteVarInt((int)this.maxLifePoints);
			writer.WriteVarShort((int)this.prospecting);
			writer.WriteByte(this.regenRate);
			writer.WriteVarShort((int)this.initiative);
			writer.WriteSByte(this.alignmentSide);
			writer.WriteShort(this.worldX);
			writer.WriteShort(this.worldY);
			writer.WriteInt(this.mapId);
			writer.WriteVarShort((int)this.subAreaId);
			writer.WriteShort(this.status.TypeId);
			this.status.Serialize(writer);
			writer.WriteShort((short)((int)this.companions.Length));
			PartyCompanionMemberInformations[] partyCompanionMemberInformationsArray = this.companions;
			for (int i = 0; i < (int)partyCompanionMemberInformationsArray.Length; i++)
			{
				partyCompanionMemberInformationsArray[i].Serialize(writer);
			}
		}
	}
}