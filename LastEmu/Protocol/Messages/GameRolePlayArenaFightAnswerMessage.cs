using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameRolePlayArenaFightAnswerMessage : NetworkMessage
	{
		public const uint Id = 6279;

		public int fightId;

		public bool accept;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6279;
			}
		}

		public GameRolePlayArenaFightAnswerMessage()
		{
		}

		public GameRolePlayArenaFightAnswerMessage(int fightId, bool accept)
		{
			this.fightId = fightId;
			this.accept = accept;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.fightId = reader.ReadInt();
			this.accept = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.fightId);
			writer.WriteBoolean(this.accept);
		}
	}
}