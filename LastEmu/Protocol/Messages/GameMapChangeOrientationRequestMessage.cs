using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameMapChangeOrientationRequestMessage : NetworkMessage
	{
		public const uint Id = 945;

		public sbyte direction;

		public override uint ProtocolId
		{
			get
			{
				return (uint)945;
			}
		}

		public GameMapChangeOrientationRequestMessage()
		{
		}

		public GameMapChangeOrientationRequestMessage(sbyte direction)
		{
			this.direction = direction;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.direction = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.direction);
		}
	}
}