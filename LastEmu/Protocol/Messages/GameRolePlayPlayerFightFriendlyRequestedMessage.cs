using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameRolePlayPlayerFightFriendlyRequestedMessage : NetworkMessage
	{
		public const uint Id = 5937;

		public int fightId;

		public double sourceId;

		public double targetId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5937;
			}
		}

		public GameRolePlayPlayerFightFriendlyRequestedMessage()
		{
		}

		public GameRolePlayPlayerFightFriendlyRequestedMessage(int fightId, double sourceId, double targetId)
		{
			this.fightId = fightId;
			this.sourceId = sourceId;
			this.targetId = targetId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.fightId = reader.ReadInt();
			this.sourceId = reader.ReadVarUhLong();
			this.targetId = reader.ReadVarUhLong();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.fightId);
			writer.WriteVarLong(this.sourceId);
			writer.WriteVarLong(this.targetId);
		}
	}
}