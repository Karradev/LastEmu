using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ServerSelectionMessage : NetworkMessage
	{
		public const uint Id = 40;

		public uint serverId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)40;
			}
		}

		public ServerSelectionMessage()
		{
		}

		public ServerSelectionMessage(uint serverId)
		{
			this.serverId = serverId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.serverId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.serverId);
		}
	}
}