using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class PartyCompanionUpdateLightMessage : PartyUpdateLightMessage
	{
		public const uint Id = 6472;

		public sbyte indexId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6472;
			}
		}

		public PartyCompanionUpdateLightMessage()
		{
		}

		public PartyCompanionUpdateLightMessage(uint partyId, double id, uint lifePoints, uint maxLifePoints, uint prospecting, byte regenRate, sbyte indexId) : base(partyId, id, lifePoints, maxLifePoints, prospecting, regenRate)
		{
			this.indexId = indexId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.indexId = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteSByte(this.indexId);
		}
	}
}