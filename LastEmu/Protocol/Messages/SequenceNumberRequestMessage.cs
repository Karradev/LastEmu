using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class SequenceNumberRequestMessage : NetworkMessage
	{
		public const uint Id = 6316;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6316;
			}
		}

		public SequenceNumberRequestMessage()
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