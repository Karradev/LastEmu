using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class RoomAvailableUpdateMessage : NetworkMessage
	{
		public const uint Id = 6630;

		public byte nbRoom;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6630;
			}
		}

		public RoomAvailableUpdateMessage()
		{
		}

		public RoomAvailableUpdateMessage(byte nbRoom)
		{
			this.nbRoom = nbRoom;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.nbRoom = reader.ReadByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteByte(this.nbRoom);
		}
	}
}