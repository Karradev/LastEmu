using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class GameActionFightLifePointsGainMessage : AbstractGameActionMessage
	{
		public const uint Id = 6311;

		public double targetId;

		public uint delta;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6311;
			}
		}

		public GameActionFightLifePointsGainMessage()
		{
		}

		public GameActionFightLifePointsGainMessage(uint actionId, double sourceId, double targetId, uint delta) : base(actionId, sourceId)
		{
			this.targetId = targetId;
			this.delta = delta;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.targetId = reader.ReadDouble();
			this.delta = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteDouble(this.targetId);
			writer.WriteVarInt((int)this.delta);
		}
	}
}