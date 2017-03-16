using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class ServersListMessage : NetworkMessage
	{
		public const uint Id = 30;

		public GameServerInformations[] servers;

		public uint alreadyConnectedToServerId;

		public bool canCreateNewCharacter;

		public override uint ProtocolId
		{
			get
			{
				return (uint)30;
			}
		}

		public ServersListMessage()
		{
		}

		public ServersListMessage(GameServerInformations[] servers, uint alreadyConnectedToServerId, bool canCreateNewCharacter)
		{
			this.servers = servers;
			this.alreadyConnectedToServerId = alreadyConnectedToServerId;
			this.canCreateNewCharacter = canCreateNewCharacter;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.servers = new GameServerInformations[num];
			for (int i = 0; i < num; i++)
			{
				this.servers[i] = new GameServerInformations();
				this.servers[i].Deserialize(reader);
			}
			this.alreadyConnectedToServerId = reader.ReadVarUhShort();
			this.canCreateNewCharacter = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.servers.Length));
			GameServerInformations[] gameServerInformationsArray = this.servers;
			for (int i = 0; i < (int)gameServerInformationsArray.Length; i++)
			{
				gameServerInformationsArray[i].Serialize(writer);
			}
			writer.WriteVarShort((int)this.alreadyConnectedToServerId);
			writer.WriteBoolean(this.canCreateNewCharacter);
		}
	}
}