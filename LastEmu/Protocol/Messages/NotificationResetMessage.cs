using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class NotificationResetMessage : NetworkMessage
	{
		public const uint Id = 6089;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6089;
			}
		}

		public NotificationResetMessage()
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