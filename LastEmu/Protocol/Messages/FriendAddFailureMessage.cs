using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class FriendAddFailureMessage : NetworkMessage
	{
		public const uint Id = 5600;

		public sbyte reason;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5600;
			}
		}

		public FriendAddFailureMessage()
		{
		}

		public FriendAddFailureMessage(sbyte reason)
		{
			this.reason = reason;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.reason = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.reason);
		}
	}
}