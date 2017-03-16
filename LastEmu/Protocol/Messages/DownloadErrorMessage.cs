using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class DownloadErrorMessage : NetworkMessage
	{
		public const uint Id = 1513;

		public sbyte errorId;

		public string message;

		public string helpUrl;

		public override uint ProtocolId
		{
			get
			{
				return (uint)1513;
			}
		}

		public DownloadErrorMessage()
		{
		}

		public DownloadErrorMessage(sbyte errorId, string message, string helpUrl)
		{
			this.errorId = errorId;
			this.message = message;
			this.helpUrl = helpUrl;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.errorId = reader.ReadSByte();
			this.message = reader.ReadUTF();
			this.helpUrl = reader.ReadUTF();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.errorId);
			writer.WriteUTF(this.message);
			writer.WriteUTF(this.helpUrl);
		}
	}
}