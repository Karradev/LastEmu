using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ObjectAveragePricesGetMessage : NetworkMessage
	{
		public const uint Id = 6334;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6334;
			}
		}

		public ObjectAveragePricesGetMessage()
		{
		}

		public override void Deserialize(IDataReader reader)
		{
		}

		public override void Serialize(IDataWriter writer)
		{
		}
	}
}