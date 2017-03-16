using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameFightJoinRequestMessage : NetworkMessage
	{
		public const uint Id = 701;

		public double fighterId;

		public int fightId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)701;
			}
		}

		public GameFightJoinRequestMessage()
		{
		}

		public GameFightJoinRequestMessage(double fighterId, int fightId)
		{
			this.fighterId = fighterId;
			this.fightId = fightId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.fighterId = reader.ReadDouble();
			this.fightId = reader.ReadInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(this.fighterId);
			writer.WriteInt(this.fightId);
		}
	}
}