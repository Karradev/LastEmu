using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class NpcDialogReplyMessage : NetworkMessage
	{
		public const uint Id = 5616;

		public uint replyId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5616;
			}
		}

		public NpcDialogReplyMessage()
		{
		}

		public NpcDialogReplyMessage(uint replyId)
		{
			this.replyId = replyId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.replyId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.replyId);
		}
	}
}