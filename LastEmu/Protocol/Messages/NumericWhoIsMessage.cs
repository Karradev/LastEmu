using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class NumericWhoIsMessage : NetworkMessage
	{
		public const uint Id = 6297;

		public double playerId;

		public int accountId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6297;
			}
		}

		public NumericWhoIsMessage()
		{
		}

		public NumericWhoIsMessage(double playerId, int accountId)
		{
			this.playerId = playerId;
			this.accountId = accountId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.playerId = reader.ReadVarUhLong();
			this.accountId = reader.ReadInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(this.playerId);
			writer.WriteInt(this.accountId);
		}
	}
}