using Protocol.IO;

using System;

namespace Protocol.Types
{
	public class FriendSpouseOnlineInformations : FriendSpouseInformations
	{
		public const short Id = 93;

		public bool inFight;

		public bool followSpouse;

		public int mapId;

		public uint subAreaId;

		public override short TypeId
		{
			get
			{
				return 93;
			}
		}

		public FriendSpouseOnlineInformations()
		{
		}

		public FriendSpouseOnlineInformations(int spouseAccountId, double spouseId, string spouseName, byte spouseLevel, sbyte breed, sbyte sex, EntityLook spouseEntityLook, GuildInformations guildInfo, sbyte alignmentSide, bool inFight, bool followSpouse, int mapId, uint subAreaId) : base(spouseAccountId, spouseId, spouseName, spouseLevel, breed, sex, spouseEntityLook, guildInfo, alignmentSide)
		{
			this.inFight = inFight;
			this.followSpouse = followSpouse;
			this.mapId = mapId;
			this.subAreaId = subAreaId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			byte num = reader.ReadByte();
			this.inFight = BooleanByteWrapper.GetFlag(num, 0);
			this.followSpouse = BooleanByteWrapper.GetFlag(num, 1);
			this.mapId = reader.ReadInt();
			this.subAreaId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			byte num = BooleanByteWrapper.SetFlag(0, 0, this.inFight);
			writer.WriteByte(BooleanByteWrapper.SetFlag(num, 1, this.followSpouse));
			writer.WriteInt(this.mapId);
			writer.WriteVarShort((int)this.subAreaId);
		}
	}
}