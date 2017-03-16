using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class StopToListenRunningFightRequestMessage : NetworkMessage
	{
		public const uint Id = 6124;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6124;
			}
		}

		public StopToListenRunningFightRequestMessage()
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