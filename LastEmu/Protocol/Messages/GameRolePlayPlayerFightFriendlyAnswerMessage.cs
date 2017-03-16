using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameRolePlayPlayerFightFriendlyAnswerMessage : NetworkMessage
	{
		public const uint Id = 5732;

		public int fightId;

		public bool accept;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5732;
			}
		}

		public GameRolePlayPlayerFightFriendlyAnswerMessage()
		{
		}

		public GameRolePlayPlayerFightFriendlyAnswerMessage(int fightId, bool accept)
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