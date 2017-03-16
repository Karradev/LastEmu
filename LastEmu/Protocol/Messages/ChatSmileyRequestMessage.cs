using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ChatSmileyRequestMessage : NetworkMessage
	{
		public const uint Id = 800;

		public uint smileyId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)800;
			}
		}

		public ChatSmileyRequestMessage()
		{
		}

		public ChatSmileyRequestMessage(uint smileyId)
		{
			this.smileyId = smileyId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.smileyId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.smileyId);
		}
	}
}