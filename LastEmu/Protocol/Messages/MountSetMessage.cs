using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class MountSetMessage : NetworkMessage
	{
		public const uint Id = 5968;

		public MountClientData mountData;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5968;
			}
		}

		public MountSetMessage()
		{
		}

		public MountSetMessage(MountClientData mountData)
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