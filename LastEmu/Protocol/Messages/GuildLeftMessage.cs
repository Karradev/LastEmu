using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GuildLeftMessage : NetworkMessage
	{
		public const uint Id = 5562;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5562;
			}
		}

		public GuildLeftMessage()
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