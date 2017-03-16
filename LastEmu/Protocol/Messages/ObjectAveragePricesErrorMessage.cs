using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ObjectAveragePricesErrorMessage : NetworkMessage
	{
		public const uint Id = 6336;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6336;
			}
		}

		public ObjectAveragePricesErrorMessage()
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