using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class LifePointsRegenBeginMessage : NetworkMessage
	{
		public const uint Id = 5684;

		public byte regenRate;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5684;
			}
		}

		public LifePointsRegenBeginMessage()
		{
		}

		public LifePointsRegenBeginMessage(byte regenRate)
		{
			this.regenRate = regenRate;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.regenRate = reader.ReadByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteByte(this.regenRate);
		}
	}
}