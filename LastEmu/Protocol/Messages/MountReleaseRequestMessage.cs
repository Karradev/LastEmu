using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class MountReleaseRequestMessage : NetworkMessage
	{
		public const uint Id = 5980;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5980;
			}
		}

		public MountReleaseRequestMessage()
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