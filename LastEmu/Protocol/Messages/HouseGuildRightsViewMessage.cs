using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class HouseGuildRightsViewMessage : NetworkMessage
	{
		public const uint Id = 5700;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5700;
			}
		}

		public HouseGuildRightsViewMessage()
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