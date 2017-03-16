using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class EnterHavenBagRequestMessage : NetworkMessage
	{
		public const uint Id = 6636;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6636;
			}
		}

		public EnterHavenBagRequestMessage()
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