using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class MailStatusMessage : NetworkMessage
	{
		public const uint Id = 6275;

		public uint unread;

		public uint total;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6275;
			}
		}

		public MailStatusMessage()
		{
		}

		public MailStatusMessage(uint unread, uint total)
		{
			this.unread = unread;
			this.total = total;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.unread = reader.ReadVarUhShort();
			this.total = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.unread);
			writer.WriteVarShort((int)this.total);
		}
	}
}