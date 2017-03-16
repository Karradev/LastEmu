using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ChatSmileyMessage : NetworkMessage
	{
		public const uint Id = 801;

		public double entityId;

		public uint smileyId;

		public int accountId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)801;
			}
		}

		public ChatSmileyMessage()
		{
		}

		public ChatSmileyMessage(double entityId, uint smileyId, int accountId)
		{
			this.entityId = entityId;
			this.smileyId = smileyId;
			this.accountId = accountId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.entityId = reader.ReadDouble();
			this.smileyId = reader.ReadVarUhShort();
			this.accountId = reader.ReadInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(this.entityId);
			writer.WriteVarShort((int)this.smileyId);
			writer.WriteInt(this.accountId);
		}
	}
}