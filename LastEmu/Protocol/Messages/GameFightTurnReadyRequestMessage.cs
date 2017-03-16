using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameFightTurnReadyRequestMessage : NetworkMessage
	{
		public const uint Id = 715;

		public double id;

		public override uint ProtocolId
		{
			get
			{
				return (uint)715;
			}
		}

		public GameFightTurnReadyRequestMessage()
		{
		}

		public GameFightTurnReadyRequestMessage(double id)
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