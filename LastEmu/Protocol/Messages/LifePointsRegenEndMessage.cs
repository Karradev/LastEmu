using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class LifePointsRegenEndMessage : UpdateLifePointsMessage
	{
		public const uint Id = 5686;

		public uint lifePointsGained;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5686;
			}
		}

		public LifePointsRegenEndMessage()
		{
		}

		public LifePointsRegenEndMessage(uint lifePoints, uint maxLifePoints, uint lifePointsGained) : base(lifePoints, maxLifePoints)
		{
			this.lifePointsGained = lifePointsGained;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.lifePointsGained = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((int)this.lifePointsGained);
		}
	}
}