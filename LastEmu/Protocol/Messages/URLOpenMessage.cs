using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class URLOpenMessage : NetworkMessage
	{
		public const uint Id = 6266;

		public sbyte urlId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6266;
			}
		}

		public URLOpenMessage()
		{
		}

		public URLOpenMessage(sbyte urlId)
		{
			this.urlId = urlId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.urlId = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.urlId);
		}
	}
}