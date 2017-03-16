using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameRolePlayRemoveChallengeMessage : NetworkMessage
	{
		public const uint Id = 300;

		public int fightId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)300;
			}
		}

		public GameRolePlayRemoveChallengeMessage()
		{
		}

		public GameRolePlayRemoveChallengeMessage(int fightId)
		{
			this.fightId = fightId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.fightId = reader.ReadInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.fightId);
		}
	}
}