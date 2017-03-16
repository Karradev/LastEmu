using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameRolePlayFightRequestCanceledMessage : NetworkMessage
	{
		public const uint Id = 5822;

		public int fightId;

		public double sourceId;

		public double targetId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5822;
			}
		}

		public GameRolePlayFightRequestCanceledMessage()
		{
		}

		public GameRolePlayFightRequestCanceledMessage(int fightId, double sourceId, double targetId)
		{
			this.fightId = fightId;
			this.sourceId = sourceId;
			this.targetId = targetId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.fightId = reader.ReadInt();
			this.sourceId = reader.ReadDouble();
			this.targetId = reader.ReadDouble();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.fightId);
			writer.WriteDouble(this.sourceId);
			writer.WriteDouble(this.targetId);
		}
	}
}