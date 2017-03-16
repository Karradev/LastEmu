using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class UpdateLifePointsMessage : NetworkMessage
	{
		public const uint Id = 5658;

		public uint lifePoints;

		public uint maxLifePoints;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5658;
			}
		}

		public UpdateLifePointsMessage()
		{
		}

		public UpdateLifePointsMessage(uint lifePoints, uint maxLifePoints)
		{
			this.lifePoints = lifePoints;
			this.maxLifePoints = maxLifePoints;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.lifePoints = reader.ReadVarUhInt();
			this.maxLifePoints = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.lifePoints);
			writer.WriteVarInt((int)this.maxLifePoints);
		}
	}
}