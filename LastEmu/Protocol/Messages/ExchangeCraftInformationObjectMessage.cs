using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class ExchangeCraftInformationObjectMessage : ExchangeCraftResultWithObjectIdMessage
	{
		public const uint Id = 5794;

		public double playerId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5794;
			}
		}

		public ExchangeCraftInformationObjectMessage()
		{
		}

		public ExchangeCraftInformationObjectMessage(sbyte craftResult, uint objectGenericId, double playerId) : base(craftResult, objectGenericId)
		{
			this.playerId = playerId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.playerId = reader.ReadVarUhLong();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarLong(this.playerId);
		}
	}
}