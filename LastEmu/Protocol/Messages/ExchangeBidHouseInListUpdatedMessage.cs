using Protocol.IO;
using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class ExchangeBidHouseInListUpdatedMessage : ExchangeBidHouseInListAddedMessage
	{
		public const uint Id = 6337;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6337;
			}
		}

		public ExchangeBidHouseInListUpdatedMessage()
		{
		}

		public ExchangeBidHouseInListUpdatedMessage(int itemUID, int objGenericId, ObjectEffect[] effects, uint[] prices) : base(itemUID, objGenericId, effects, prices)
		{
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
		}
	}
}