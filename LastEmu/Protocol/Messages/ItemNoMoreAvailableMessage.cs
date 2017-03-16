using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ItemNoMoreAvailableMessage : NetworkMessage
	{
		public const uint Id = 5769;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5769;
			}
		}

		public ItemNoMoreAvailableMessage()
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