using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class MountToggleRidingRequestMessage : NetworkMessage
	{
		public const uint Id = 5976;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5976;
			}
		}

		public MountToggleRidingRequestMessage()
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