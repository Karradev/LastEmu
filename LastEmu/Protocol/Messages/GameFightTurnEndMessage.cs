using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameFightTurnEndMessage : NetworkMessage
	{
		public const uint Id = 719;

		public double id;

		public override uint ProtocolId
		{
			get
			{
				return (uint)719;
			}
		}

		public GameFightTurnEndMessage()
		{
		}

		public GameFightTurnEndMessage(double id)
		{
			this.id = id;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.id = reader.ReadDouble();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(this.id);
		}
	}
}