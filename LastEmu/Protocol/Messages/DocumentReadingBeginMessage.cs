using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class DocumentReadingBeginMessage : NetworkMessage
	{
		public const uint Id = 5675;

		public uint documentId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5675;
			}
		}

		public DocumentReadingBeginMessage()
		{
		}

		public DocumentReadingBeginMessage(uint documentId)
		{
			this.documentId = documentId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.documentId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.documentId);
		}
	}
}