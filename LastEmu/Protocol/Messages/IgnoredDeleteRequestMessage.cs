using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class IgnoredDeleteRequestMessage : NetworkMessage
	{
		public const uint Id = 5680;

		public int accountId;

		public bool session;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5680;
			}
		}

		public IgnoredDeleteRequestMessage()
		{
		}

		public IgnoredDeleteRequestMessage(int accountId, bool session)
		{
			this.accountId = accountId;
			this.session = session;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.accountId = reader.ReadInt();
			this.session = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.accountId);
			writer.WriteBoolean(this.session);
		}
	}
}