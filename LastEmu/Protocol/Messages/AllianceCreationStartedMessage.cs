using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class AllianceCreationStartedMessage : NetworkMessage
	{
		public const uint Id = 6394;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6394;
			}
		}

		public AllianceCreationStartedMessage()
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