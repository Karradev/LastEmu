using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class DownloadSetSpeedRequestMessage : NetworkMessage
	{
		public const uint Id = 1512;

		public sbyte downloadSpeed;

		public override uint ProtocolId
		{
			get
			{
				return (uint)1512;
			}
		}

		public DownloadSetSpeedRequestMessage()
		{
		}

		public DownloadSetSpeedRequestMessage(sbyte downloadSpeed)
		{
			this.downloadSpeed = downloadSpeed;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.downloadSpeed = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.downloadSpeed);
		}
	}
}