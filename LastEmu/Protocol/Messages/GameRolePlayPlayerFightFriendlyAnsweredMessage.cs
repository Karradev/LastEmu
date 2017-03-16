using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameRolePlayPlayerFightFriendlyAnsweredMessage : NetworkMessage
	{
		public const uint Id = 5733;

		public int fightId;

		public double sourceId;

		public double targetId;

		public bool accept;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5733;
			}
		}

		public GameRolePlayPlayerFightFriendlyAnsweredMessage()
		{
		}

		public GameRolePlayPlayerFightFriendlyAnsweredMessage(int fightId, double sourceId, double targetId, bool accept)
		{
			this.fightId = fightId;
			this.sourceId = sourceId;
			this.targetId = targetId;
			this.accept = accept;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.fightId = reader.ReadInt();
			this.sourceId = reader.ReadVarUhLong();
			this.targetId = reader.ReadVarUhLong();
			this.accept = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.fightId);
			writer.WriteVarLong(this.sourceId);
			writer.WriteVarLong(this.targetId);
			writer.WriteBoolean(this.accept);
		}
	}
}