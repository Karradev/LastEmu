using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class FriendInformations : AbstractContactInformations
	{
		public const short Id = 78;

		public sbyte playerState;

		public uint lastConnection;

		public int achievementPoints;

		public override short TypeId
		{
			get
			{
				return 78;
			}
		}

		public FriendInformations()
		{
		}

		public FriendInformations(int accountId, string accountName, sbyte playerState, uint lastConnection, int achievementPoints) : base(accountId, accountName)
		{
			this.playerState = playerState;
			this.lastConnection = lastConnection;
			this.achievementPoints = achievementPoints;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.playerState = reader.ReadSByte();
			this.lastConnection = reader.ReadVarUhShort();
			this.achievementPoints = reader.ReadInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteSByte(this.playerState);
			writer.WriteVarShort((int)this.lastConnection);
			writer.WriteInt(this.achievementPoints);
		}
	}
}