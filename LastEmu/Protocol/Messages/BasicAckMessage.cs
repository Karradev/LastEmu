using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class BasicAckMessage : NetworkMessage
	{
		public const uint Id = 6362;

		public uint seq;

		public uint lastPacketId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6362;
			}
		}

		public BasicAckMessage()
		{
		}

		public BasicAckMessage(uint seq, uint lastPacketId)
		{
			this.seq = seq;
			this.lastPacketId = lastPacketId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.seq = reader.ReadVarUhInt();
			this.lastPacketId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.seq);
			writer.WriteVarShort((int)this.lastPacketId);
		}
	}
}