using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class DownloadPartMessage : NetworkMessage
	{
		public const uint Id = 1503;

		public string id;

		public override uint ProtocolId
		{
			get
			{
				return (uint)1503;
			}
		}

		public DownloadPartMessage()
		{
		}

		public DownloadPartMessage(string id)
		{
			this.id = id;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.id = reader.ReadUTF();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(this.id);
		}
	}
}