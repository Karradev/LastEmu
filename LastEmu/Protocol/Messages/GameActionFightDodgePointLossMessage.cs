using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class GameActionFightDodgePointLossMessage : AbstractGameActionMessage
	{
		public const uint Id = 5828;

		public double targetId;

		public uint amount;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5828;
			}
		}

		public GameActionFightDodgePointLossMessage()
		{
		}

		public GameActionFightDodgePointLossMessage(uint actionId, double sourceId, double targetId, uint amount) : base(actionId, sourceId)
		{
			this.targetId = targetId;
			this.amount = amount;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.targetId = reader.ReadDouble();
			this.amount = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteDouble(this.targetId);
			writer.WriteVarShort((int)this.amount);
		}
	}
}