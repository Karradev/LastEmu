using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class CredentialsAcknowledgementMessage : NetworkMessage
	{
		public const uint Id = 6314;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6314;
			}
		}

		public CredentialsAcknowledgementMessage()
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