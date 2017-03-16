using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class PartyInvitationMemberInformations : CharacterBaseInformations
	{
		public const short Id = 376;

		public short worldX;

		public short worldY;

		public int mapId;

		public uint subAreaId;

		public PartyCompanionBaseInformations[] companions;

		public override short TypeId
		{
			get
			{
				return 376;
			}
		}

		public PartyInvitationMemberInformations()
		{
		}

		public PartyInvitationMemberInformations(double id, string name, byte level, EntityLook entityLook, sbyte breed, bool sex, short worldX, short worldY, int mapId, uint subAreaId, PartyCompanionBaseInformations[] companions) : base(id, name, level, entityLook, breed, sex)
		{
			this.worldX = worldX;
			this.worldY = worldY;
			this.mapId = mapId;
			this.subAreaId = subAreaId;
			this.companions = companions;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.worldX = reader.ReadShort();
			this.worldY = reader.ReadShort();
			this.mapId = reader.ReadInt();
			this.subAreaId = reader.ReadVarUhShort();
			ushort num = reader.ReadUShort();
			this.companions = new PartyCompanionBaseInformations[num];
			for (int i = 0; i < num; i++)
			{
				this.companions[i] = new PartyCompanionBaseInformations();
				this.companions[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort(this.worldX);
			writer.WriteShort(this.worldY);
			writer.WriteInt(this.mapId);
			writer.WriteVarShort((int)this.subAreaId);
			writer.WriteShort((short)((int)this.companions.Length));
			PartyCompanionBaseInformations[] partyCompanionBaseInformationsArray = this.companions;
			for (int i = 0; i < (int)partyCompanionBaseInformationsArray.Length; i++)
			{
				partyCompanionBaseInformationsArray[i].Serialize(writer);
			}
		}
	}
}