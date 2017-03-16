using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class NumericWhoIsRequestMessage : NetworkMessage
	{
		public const uint Id = 6298;

		public double playerId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6298;
			}
		}

		public NumericWhoIsRequestMessage()
		{
		}

		public NumericWhoIsRequestMessage(double playerId)
		{
			this.playerId = playerId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.playerId = reader.ReadVarUhLong();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(this.playerId);
		}
	}
}