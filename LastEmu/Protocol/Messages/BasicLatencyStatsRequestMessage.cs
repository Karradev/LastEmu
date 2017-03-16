using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class BasicLatencyStatsRequestMessage : NetworkMessage
	{
		public const uint Id = 5816;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5816;
			}
		}

		public BasicLatencyStatsRequestMessage()
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