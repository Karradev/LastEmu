using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameContextKickMessage : NetworkMessage
	{
		public const uint Id = 6081;

		public double targetId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6081;
			}
		}

		public GameContextKickMessage()
		{
		}

		public GameContextKickMessage(double targetId)
		{
			this.targetId = targetId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.targetId = reader.ReadDouble();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(this.targetId);
		}
	}
}