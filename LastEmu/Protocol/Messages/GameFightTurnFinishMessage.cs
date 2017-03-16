using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameFightTurnFinishMessage : NetworkMessage
	{
		public const uint Id = 718;

		public bool isAfk;

		public override uint ProtocolId
		{
			get
			{
				return (uint)718;
			}
		}

		public GameFightTurnFinishMessage()
		{
		}

		public GameFightTurnFinishMessage(bool isAfk)
		{
			this.isAfk = isAfk;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.isAfk = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(this.isAfk);
		}
	}
}