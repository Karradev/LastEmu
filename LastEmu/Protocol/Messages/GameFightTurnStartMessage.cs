using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameFightTurnStartMessage : NetworkMessage
	{
		public const uint Id = 714;

		public double id;

		public uint waitTime;

		public override uint ProtocolId
		{
			get
			{
				return (uint)714;
			}
		}

		public GameFightTurnStartMessage()
		{
		}

		public GameFightTurnStartMessage(double id, uint waitTime)
		{
			this.id = id;
			this.waitTime = waitTime;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.id = reader.ReadDouble();
			this.waitTime = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(this.id);
			writer.WriteVarInt((int)this.waitTime);
		}
	}
}