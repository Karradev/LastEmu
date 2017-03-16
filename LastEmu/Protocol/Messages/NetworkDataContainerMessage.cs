using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class NetworkDataContainerMessage : NetworkMessage
	{
		public const uint Id = 2;

		public override uint ProtocolId
		{
			get
			{
				return (uint)2;
			}
		}

		public NetworkDataContainerMessage()
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