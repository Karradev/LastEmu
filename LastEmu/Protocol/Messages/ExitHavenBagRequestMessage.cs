using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExitHavenBagRequestMessage : NetworkMessage
	{
		public const uint Id = 6631;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6631;
			}
		}

		public ExitHavenBagRequestMessage()
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