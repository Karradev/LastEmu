using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class AccountLinkRequiredMessage : NetworkMessage
	{
		public const uint Id = 6607;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6607;
			}
		}

		public AccountLinkRequiredMessage()
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