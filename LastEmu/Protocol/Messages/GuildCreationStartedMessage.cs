using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GuildCreationStartedMessage : NetworkMessage
	{
		public const uint Id = 5920;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5920;
			}
		}

		public GuildCreationStartedMessage()
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