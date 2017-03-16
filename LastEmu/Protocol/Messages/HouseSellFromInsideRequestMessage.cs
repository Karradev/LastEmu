using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class HouseSellFromInsideRequestMessage : HouseSellRequestMessage
	{
		public const uint Id = 5884;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5884;
			}
		}

		public HouseSellFromInsideRequestMessage()
		{
		}

		public HouseSellFromInsideRequestMessage(uint amount, bool forSale) : base(amount, forSale)
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