using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class SelectedServerRefusedMessage : NetworkMessage
	{
		public const uint Id = 41;

		public uint serverId;

		public sbyte error;

		public sbyte serverStatus;

		public override uint ProtocolId
		{
			get
			{
				return (uint)41;
			}
		}

		public SelectedServerRefusedMessage()
		{
		}

		public SelectedServerRefusedMessage(uint serverId, sbyte error, sbyte serverStatus)
		{
			this.serverId = serverId;
			this.error = error;
			this.serverStatus = serverStatus;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.serverId = reader.ReadVarUhShort();
			this.error = reader.ReadSByte();
			this.serverStatus = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.serverId);
			writer.WriteSByte(this.error);
			writer.WriteSByte(this.serverStatus);
		}
	}
}