using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class GoldAddedMessage : NetworkMessage
	{
		public const uint Id = 6030;

		public GoldItem gold;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6030;
			}
		}

		public GoldAddedMessage()
		{
		}

		public GoldAddedMessage(GoldItem gold)
		{
			this.gold = gold;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.gold = new GoldItem();
			this.gold.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			this.gold.Serialize(writer);
		}
	}
}