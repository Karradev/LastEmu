using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class LocalizedChatSmileyMessage : ChatSmileyMessage
	{
		public const uint Id = 6185;

		public uint cellId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6185;
			}
		}

		public LocalizedChatSmileyMessage()
		{
		}

		public LocalizedChatSmileyMessage(double entityId, uint smileyId, int accountId, uint cellId) : base(entityId, smileyId, accountId)
		{
			this.cellId = cellId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.cellId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((int)this.cellId);
		}
	}
}