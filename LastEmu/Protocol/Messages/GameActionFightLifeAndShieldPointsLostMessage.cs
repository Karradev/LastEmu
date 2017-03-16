using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class GameActionFightLifeAndShieldPointsLostMessage : GameActionFightLifePointsLostMessage
	{
		public const uint Id = 6310;

		public uint shieldLoss;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6310;
			}
		}

		public GameActionFightLifeAndShieldPointsLostMessage()
		{
		}

		public GameActionFightLifeAndShieldPointsLostMessage(uint actionId, double sourceId, double targetId, uint loss, uint permanentDamages, uint shieldLoss) : base(actionId, sourceId, targetId, loss, permanentDamages)
		{
			this.shieldLoss = shieldLoss;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.shieldLoss = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((int)this.shieldLoss);
		}
	}
}