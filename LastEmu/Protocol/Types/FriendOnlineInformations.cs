using Protocol.IO;

using System;

namespace Protocol.Types
{
	public class FriendOnlineInformations : FriendInformations
	{
		public const short Id = 92;

		public double playerId;

		public string playerName;

		public byte level;

		public sbyte alignmentSide;

		public sbyte breed;

		public bool sex;

		public GuildInformations guildInfo;

		public uint moodSmileyId;

		public PlayerStatus status;

		public override short TypeId
		{
			get
			{
				return 92;
			}
		}

		public FriendOnlineInformations()
		{
		}

		public FriendOnlineInformations(int accountId, string accountName, sbyte playerState, uint lastConnection, int achievementPoints, double playerId, string playerName, byte level, sbyte alignmentSide, sbyte breed, bool sex, GuildInformations guildInfo, uint moodSmileyId, PlayerStatus status) : base(accountId, accountName, playerState, lastConnection, achievementPoints)
		{
			this.playerId = playerId;
			this.playerName = playerName;
			this.level = level;
			this.alignmentSide = alignmentSide;
			this.breed = breed;
			this.sex = sex;
			this.guildInfo = guildInfo;
			this.moodSmileyId = moodSmileyId;
			this.status = status;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.playerId = reader.ReadVarUhLong();
			this.playerName = reader.ReadUTF();
			this.level = reader.ReadByte();
			this.alignmentSide = reader.ReadSByte();
			this.breed = reader.ReadSByte();
			this.sex = reader.ReadBoolean();
			this.guildInfo = new GuildInformations();
			this.guildInfo.Deserialize(reader);
			this.moodSmileyId = reader.ReadVarUhShort();
			this.status = ProtocolTypeManager.GetInstance<PlayerStatus>(reader.ReadUShort());
			this.status.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarLong(this.playerId);
			writer.WriteUTF(this.playerName);
			writer.WriteByte(this.level);
			writer.WriteSByte(this.alignmentSide);
			writer.WriteSByte(this.breed);
			writer.WriteBoolean(this.sex);
			this.guildInfo.Serialize(writer);
			writer.WriteVarShort((int)this.moodSmileyId);
			writer.WriteShort(this.status.TypeId);
			this.status.Serialize(writer);
		}
	}
}