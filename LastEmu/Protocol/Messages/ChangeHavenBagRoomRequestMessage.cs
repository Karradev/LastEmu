using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ChangeHavenBagRoomRequestMessage : NetworkMessage
	{
		public const uint Id = 6638;

		public sbyte roomId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6638;
			}
		}

		public ChangeHavenBagRoomRequestMessage()
		{
		}

		public ChangeHavenBagRoomRequestMessage(sbyte roomId)
		{
			this.roomId = roomId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.roomId = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.roomId);
		}
	}
}