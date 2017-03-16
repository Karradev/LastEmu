using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class MountDataMessage : NetworkMessage
	{
		public const uint Id = 5973;

		public MountClientData mountData;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5973;
			}
		}

		public MountDataMessage()
		{
		}

		public MountDataMessage(MountClientData mountData)
		{
			this.mountData = mountData;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.mountData = new MountClientData();
			this.mountData.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			this.mountData.Serialize(writer);
		}
	}
}