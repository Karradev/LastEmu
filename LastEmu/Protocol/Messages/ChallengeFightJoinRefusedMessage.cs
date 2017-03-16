using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ChallengeFightJoinRefusedMessage : NetworkMessage
	{
		public const uint Id = 5908;

		public double playerId;

		public sbyte reason;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5908;
			}
		}

		public ChallengeFightJoinRefusedMessage()
		{
		}

		public ChallengeFightJoinRefusedMessage(double playerId, sbyte reason)
		{
			this.playerId = playerId;
			this.reason = reason;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.playerId = reader.ReadVarUhLong();
			this.reason = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(this.playerId);
			writer.WriteSByte(this.reason);
		}
	}
}