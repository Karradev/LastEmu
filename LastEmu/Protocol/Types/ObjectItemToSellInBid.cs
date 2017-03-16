using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class ObjectItemToSellInBid : ObjectItemToSell
	{
		public const short Id = 164;

		public int unsoldDelay;

		public override short TypeId
		{
			get
			{
				return 164;
			}
		}

		public ObjectItemToSellInBid()
		{
		}

		public ObjectItemToSellInBid(uint objectGID, ObjectEffect[] effects, uint objectUID, uint quantity, uint objectPrice, int unsoldDelay) : base(objectGID, effects, objectUID, quantity, objectPrice)
		{
			this.unsoldDelay = unsoldDelay;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.unsoldDelay = reader.ReadInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt(this.unsoldDelay);
		}
	}
}