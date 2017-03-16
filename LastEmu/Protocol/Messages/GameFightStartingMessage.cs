using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameFightStartingMessage : NetworkMessage
	{
		public const uint Id = 700;

		public sbyte fightType;

		public double attackerId;

		public double defenderId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)700;
			}
		}

		public GameFightStartingMessage()
		{
		}

		public GameFightStartingMessage(sbyte fightType, double attackerId, double defenderId)
		{
			this.fightType = fightType;
			this.attackerId = attackerId;
			this.defenderId = defenderId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.fightType = reader.ReadSByte();
			this.attackerId = reader.ReadDouble();
			this.defenderId = reader.ReadDouble();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.fightType);
			writer.WriteDouble(this.attackerId);
			writer.WriteDouble(this.defenderId);
		}
	}
}