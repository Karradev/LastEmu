using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameRolePlayAggressionMessage : NetworkMessage
	{
		public const uint Id = 6073;

		public double attackerId;

		public double defenderId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6073;
			}
		}

		public GameRolePlayAggressionMessage()
		{
		}

		public GameRolePlayAggressionMessage(double attackerId, double defenderId)
		{
			this.attackerId = attackerId;
			this.defenderId = defenderId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.attackerId = reader.ReadVarUhLong();
			this.defenderId = reader.ReadVarUhLong();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(this.attackerId);
			writer.WriteVarLong(this.defenderId);
		}
	}
}