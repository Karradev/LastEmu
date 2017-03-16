using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class DownloadGetCurrentSpeedRequestMessage : NetworkMessage
	{
		public const uint Id = 1510;

		public override uint ProtocolId
		{
			get
			{
				return (uint)1510;
			}
		}

		public DownloadGetCurrentSpeedRequestMessage()
		{
		}

		public override void Deserialize(IDataReader reader)
		{
		}

		public override void Serialize(IDataWriter writer)
		{
		}
	}
}