using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ComicReadingBeginMessage : NetworkMessage
	{
		public const uint Id = 6536;

		public uint comicId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6536;
			}
		}

		public ComicReadingBeginMessage()
		{
		}

		public ComicReadingBeginMessage(uint comicId)
		{
			this.comicId = comicId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.comicId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.comicId);
		}
	}
}