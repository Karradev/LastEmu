using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class ServerStatusUpdateMessage : NetworkMessage
	{
		public const uint Id = 50;

		public GameServerInformations server;

		public override uint ProtocolId
		{
			get
			{
				return (uint)50;
			}
		}

		public ServerStatusUpdateMessage()
		{
		}

		public ServerStatusUpdateMessage(GameServerInformations server)
		{
			this.server = server;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.server = new GameServerInformations();
			this.server.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			this.server.Serialize(writer);
		}
	}
}