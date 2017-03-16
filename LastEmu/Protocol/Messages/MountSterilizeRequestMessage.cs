using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class MountSterilizeRequestMessage : NetworkMessage
	{
		public const uint Id = 5962;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5962;
			}
		}

		public MountSterilizeRequestMessage()
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