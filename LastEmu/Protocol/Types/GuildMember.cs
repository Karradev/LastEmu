using Protocol.IO;

using System;

namespace Protocol.Types
{
	public class GuildMember : CharacterMinimalInformations
	{
		public const short Id = 88;

		public sbyte breed;

		public bool sex;

		public uint rank;

		public double givenExperience;

		public sbyte experienceGivenPercent;

		public uint rights;

		public sbyte connected;

		public sbyte alignmentSide;

		public ushort hoursSinceLastConnection;

		public uint moodSmileyId;

		public int accountId;

		public int achievementPoints;

		public PlayerStatus status;

		public override short TypeId
		{
			get
			{
				return 88;
			}
		}

		public GuildMember()
		{
		}

		public GuildMember(double id, string name, byte level, sbyte breed, bool sex, uint rank, double givenExperience, sbyte experienceGivenPercent, uint rights, sbyte connected, sbyte alignmentSide, ushort hoursSinceLastConnection, uint moodSmileyId, int accountId, int achievementPoints, PlayerStatus status) : base(id, name, level)
		{
			this.breed = breed;
			this.sex = sex;
			this.rank = rank;
			this.givenExperience = givenExperience;
			this.experienceGivenPercent = experienceGivenPercent;
			this.rights = rights;
			this.connected = connected;
			this.alignmentSide = alignmentSide;
			this.hoursSinceLastConnection = hoursSinceLastConnection;
			this.moodSmileyId = moodSmileyId;
			this.accountId = accountId;
			this.achievementPoints = achievementPoints;
			this.status = status;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.breed = reader.ReadSByte();
			this.sex = reader.ReadBoolean();
			this.rank = reader.ReadVarUhShort();
			this.givenExperience = reader.ReadVarUhLong();
			this.experienceGivenPercent = reader.ReadSByte();
			this.rights = reader.ReadVarUhInt();
			this.connected = reader.ReadSByte();
			this.alignmentSide = reader.ReadSByte();
			this.hoursSinceLastConnection = reader.ReadUShort();
			this.moodSmileyId = reader.ReadVarUhShort();
			this.accountId = reader.ReadInt();
			this.achievementPoints = reader.ReadInt();
			this.status = ProtocolTypeManager.GetInstance<PlayerStatus>(reader.ReadUShort());
			this.status.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteSByte(this.breed);
			writer.WriteBoolean(this.sex);
			writer.WriteVarShort((int)this.rank);
			writer.WriteVarLong(this.givenExperience);
			writer.WriteSByte(this.experienceGivenPercent);
			writer.WriteVarInt((int)this.rights);
			writer.WriteSByte(this.connected);
			writer.WriteSByte(this.alignmentSide);
			writer.WriteUShort(this.hoursSinceLastConnection);
			writer.WriteVarShort((int)this.moodSmileyId);
			writer.WriteInt(this.accountId);
			writer.WriteInt(this.achievementPoints);
			writer.WriteShort(this.status.TypeId);
			this.status.Serialize(writer);
		}
	}
}