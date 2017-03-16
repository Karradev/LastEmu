using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class GameActionFightReduceDamagesMessage : AbstractGameActionMessage
	{
		public const uint Id = 5526;

		public double targetId;

		public uint amount;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5526;
			}
		}

		public GameActionFightReduceDamagesMessage()
		{
		}

		public GameActionFightReduceDamagesMessage(uint actionId, double sourceId, double targetId, uint amount) : base(actionId, sourceId)
		{
			this.targetId = targetId;
			this.amount = amount;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.targetId = reader.ReadDouble();
			this.amount = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteDouble(this.targetId);
			writer.WriteVarInt((int)this.amount);
		}
	}
}