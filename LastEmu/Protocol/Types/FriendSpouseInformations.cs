using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class FriendSpouseInformations
	{
		public const short Id = 77;

		public int spouseAccountId;

		public double spouseId;

		public string spouseName;

		public byte spouseLevel;

		public sbyte breed;

		public sbyte sex;

		public EntityLook spouseEntityLook;

		public GuildInformations guildInfo;

		public sbyte alignmentSide;

		public virtual short TypeId
		{
			get
			{
				return 77;
			}
		}

		public FriendSpouseInformations()
		{
		}

		public FriendSpouseInformations(int spouseAccountId, double spouseId, string spouseName, byte spouseLevel, sbyte breed, sbyte sex, EntityLook spouseEntityLook, GuildInformations guildInfo, sbyte alignmentSide)
		{
			this.spouseAccountId = spouseAccountId;
			this.spouseId = spouseId;
			this.spouseName = spouseName;
			this.spouseLevel = spouseLevel;
			this.breed = breed;
			this.sex = sex;
			this.spouseEntityLook = spouseEntityLook;
			this.guildInfo = guildInfo;
			this.alignmentSide = alignmentSide;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.spouseAccountId = reader.ReadInt();
			this.spouseId = reader.ReadVarUhLong();
			this.spouseName = reader.ReadUTF();
			this.spouseLevel = reader.ReadByte();
			this.breed = reader.ReadSByte();
			this.sex = reader.ReadSByte();
			this.spouseEntityLook = new EntityLook();
			this.spouseEntityLook.Deserialize(reader);
			this.guildInfo = new GuildInformations();
			this.guildInfo.Deserialize(reader);
			this.alignmentSide = reader.ReadSByte();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.spouseAccountId);
			writer.WriteVarLong(this.spouseId);
			writer.WriteUTF(this.spouseName);
			writer.WriteByte(this.spouseLevel);
			writer.WriteSByte(this.breed);
			writer.WriteSByte(this.sex);
			this.spouseEntityLook.Serialize(writer);
			this.guildInfo.Serialize(writer);
			writer.WriteSByte(this.alignmentSide);
		}
	}
}