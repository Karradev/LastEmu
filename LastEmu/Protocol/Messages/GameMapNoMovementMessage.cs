using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameMapNoMovementMessage : NetworkMessage
	{
		public const uint Id = 954;

		public short cellX;

		public short cellY;

		public override uint ProtocolId
		{
			get
			{
				return (uint)954;
			}
		}

		public GameMapNoMovementMessage()
		{
		}

		public GameMapNoMovementMessage(short cellX, short cellY)
		{
			this.cellX = cellX;
			this.cellY = cellY;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.cellX = reader.ReadShort();
			this.cellY = reader.ReadShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort(this.cellX);
			writer.WriteShort(this.cellY);
		}
	}
}