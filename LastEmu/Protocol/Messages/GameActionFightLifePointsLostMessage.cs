using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class GameActionFightLifePointsLostMessage : AbstractGameActionMessage
	{
		public const uint Id = 6312;

		public double targetId;

		public uint loss;

		public uint permanentDamages;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6312;
			}
		}

		public GameActionFightLifePointsLostMessage()
		{
		}

		public GameActionFightLifePointsLostMessage(uint actionId, double sourceId, double targetId, uint loss, uint permanentDamages) : base(actionId, sourceId)
		{
			this.targetId = targetId;
			this.loss = loss;
			this.permanentDamages = permanentDamages;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.targetId = reader.ReadDouble();
			this.loss = reader.ReadVarUhInt();
			this.permanentDamages = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteDouble(this.targetId);
			writer.WriteVarInt((int)this.loss);
			writer.WriteVarInt((int)this.permanentDamages);
		}
	}
}